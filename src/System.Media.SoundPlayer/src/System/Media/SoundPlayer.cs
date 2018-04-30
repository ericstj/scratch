namespace System.Media {
    using System;
    using System.IO;
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;
    using System.Runtime.Versioning;
    using System.Diagnostics;
    using System.Threading;
    using System.Net;
    using System.Globalization;
    using System.Security.Permissions;
    using System.Security;
    using System.Diagnostics.CodeAnalysis;

    [
    Serializable,
    ToolboxItem(false),
    SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes"), // This is the first class added to System.Media namespace.
    SuppressMessage("Microsoft.Usage", "CA2240:ImplementISerializableCorrectly"), // vsw 427356
    ]
    public class SoundPlayer : Component, ISerializable {

        const int blockSize = 1024;
        const int defaultLoadTimeout = 10000;// 10 secs
        private Uri uri = null;
        private string soundLocation = String.Empty;
        private int loadTimeout = defaultLoadTimeout;

        private object tag = null;

        // used to lock all synchronous calls to the SoundPlayer object
        private ManualResetEvent semaphore = new ManualResetEvent(true);

        // the worker copyThread
        // we start the worker copyThread ONLY from entry points in the SoundPlayer API
        // we also set the tread to null only from the entry points in the SoundPlayer API
        private Thread copyThread = null;

        // local buffer information
        int currentPos = 0;
        private Stream stream = null;
        private bool isLoadCompleted = false;
        private Exception lastLoadException = null;
        private bool doesLoadAppearSynchronous = false;
        private byte[] streamData = null;
        private AsyncOperation asyncOperation = null;
        private readonly SendOrPostCallback loadAsyncOperationCompleted;

        // event
        private static readonly object EventLoadCompleted = new object();
        private static readonly object EventSoundLocationChanged = new object();
        private static readonly object EventStreamChanged = new object();

        public SoundPlayer() {
            loadAsyncOperationCompleted = 
                new SendOrPostCallback(LoadAsyncOperationCompleted);
        }

        public SoundPlayer(string soundLocation) : this() {
            if(soundLocation == null) {
                soundLocation = String.Empty;
            }
            SetupSoundLocation(soundLocation);
        }

        public SoundPlayer(Stream stream) : this() {
            this.stream = stream;
        }

        /**
         * Constructor used in deserialization
         */
        [
            SuppressMessage("Microsoft.Performance", "CA1808:AvoidCallsThatBoxValueTypes"), // SerializationInfo stores LoadTimeout as an object.
            SuppressMessage("Microsoft.Performance", "CA1801:AvoidUnusedParameters")        // Serialization constructor needs a Context parameter.
        ]
        protected SoundPlayer(SerializationInfo serializationInfo, StreamingContext context) {
            foreach(SerializationEntry entry in serializationInfo) {
                switch (entry.Name) {
                    case "SoundLocation" :
                        SetupSoundLocation((string) entry.Value);
                        break;
                    case "Stream" :
                        stream = (Stream) entry.Value;
                        // when we deserialize a stream we have to reset its seek position
                        if (stream.CanSeek) {
                            stream.Seek(0, SeekOrigin.Begin);
                        }
                        break;
                    case "LoadTimeout" :
                        this.LoadTimeout = (int) entry.Value;
                        break;
                }
            }
        }

        public int LoadTimeout {
            get {
                return loadTimeout;
            }
            set {
                if (value < 0) {
                    throw new ArgumentOutOfRangeException("LoadTimeout", value, SR.SoundAPILoadTimeout);
                }

                loadTimeout = value;
            }
        }

        public string SoundLocation {
            get {
                return soundLocation;
            }
            set {
                if (value == null)
                    value = String.Empty;

                if (soundLocation.Equals(value))
                    return;

                SetupSoundLocation(value);

                OnSoundLocationChanged(EventArgs.Empty);
            }
        }

        public Stream Stream {
            get {
                // if the path is set, we should return null
                // Path and Stream are mutually exclusive
                if (uri != null)
                    return null;
                return this.stream;
            }
            set {
                if (stream == value)
                    return;

                SetupStream(value);

                OnStreamChanged(EventArgs.Empty);
            }
        }

        public bool IsLoadCompleted {
            get {
                return isLoadCompleted;
            }
        }

        public object Tag {
            get {
                return tag;
            }
            set {
                tag = value;
            }
        }

        public void LoadAsync() {
            // if we have a file there is nothing to load - we just pass the file to the PlaySound function
            // if we have a stream, then we start loading the stream async
            //
            if (uri!= null && uri.IsFile){
                Debug.Assert(stream == null, "we can't have a stream and a path at the same time");
                isLoadCompleted = true;

                FileInfo fi = new FileInfo(uri.LocalPath);
                if (!fi.Exists) {
                    throw new FileNotFoundException(SR.SoundAPIFileDoesNotExist, this.soundLocation);
                }

                OnLoadCompleted(new AsyncCompletedEventArgs(null, false, null));
                return;
            }

            // if we are actively loading, keep it running
            if (copyThread != null && copyThread.ThreadState == System.Threading.ThreadState.Running) {
                return;
            }
            isLoadCompleted = false;
            streamData = null;
            currentPos = 0;

            asyncOperation = AsyncOperationManager.CreateOperation(null);
            
            LoadStream(false);
        }

        private void LoadAsyncOperationCompleted(object arg)
        {
            OnLoadCompleted((AsyncCompletedEventArgs)arg);
        }

        // called for loading a stream synchronously
        // called either when the user is setting the path/stream and we are loading
        // or when loading took more time than the time out
        private void CleanupStreamData() {
            this.currentPos = 0;
            this.streamData = null;
            this.isLoadCompleted = false;
            this.lastLoadException = null;
            this.doesLoadAppearSynchronous = false;
            this.copyThread = null;
            this.semaphore.Set();
        }

        public void Load() {
            // if we have a file there is nothing to load - we just pass the file to the PlaySound function
            // if we have a stream, then we start loading the stream sync
            //
            if (uri != null && uri.IsFile){
                Debug.Assert(stream == null, "we can't have a stream and a path at the same time");
                FileInfo fi = new FileInfo(uri.LocalPath);
                if (!fi.Exists) {
                    throw new FileNotFoundException(SR.SoundAPIFileDoesNotExist, this.soundLocation);
                }
                isLoadCompleted = true;
                OnLoadCompleted(new AsyncCompletedEventArgs(null, false, null));
                return;
            }

            LoadSync();
        }

        private void LoadAndPlay(int flags) {
            // When the user does not specify a sound location nor a stream, play Beep
            if (String.IsNullOrEmpty(soundLocation) && stream == null) {
                SystemSounds.Beep.Play();
                return;
            }

            if (uri != null && uri.IsFile) {
                // Someone may call SoundPlayer::set_Location between the time
                // LoadAndPlay validates the sound file and the time it calls PlaySound.
                // The SoundPlayer will end up playing an un-validated sound file.
                // The solution is to store the uri.LocalPath on a local variable
                string localPath = uri.LocalPath;

                // play the path
                isLoadCompleted = true;

                // don't use uri.AbsolutePath because that gives problems when there are whitespaces in file names
                ValidateSoundFile(localPath);
                Interop.WinMM.PlaySoundW(localPath, IntPtr.Zero, Interop.WinMM.SND_NODEFAULT | flags);
            } else {
                LoadSync();
                ValidateSoundData(streamData);
                Interop.WinMM.PlaySoundW(streamData, IntPtr.Zero, Interop.WinMM.SND_MEMORY | Interop.WinMM.SND_NODEFAULT | flags);
            }
        }

        private void LoadSync() {
            
            Debug.Assert((uri == null || !uri.IsFile), "we only load streams");

            // first make sure that any possible download ended
            if (!semaphore.WaitOne(LoadTimeout, false)) {
                if (copyThread != null)
                    copyThread.Abort();
                CleanupStreamData();
                throw new TimeoutException(SR.SoundAPILoadTimedOut);
            }

            // if we have data, then we are done
            if (streamData != null)
                return;

            // setup the http stream
            if (uri != null && !uri.IsFile && stream == null) {
                WebRequest webRequest = WebRequest.Create(uri);
                webRequest.Timeout = LoadTimeout;

                WebResponse webResponse;
                webResponse = webRequest.GetResponse();

                // now get the stream
                stream = webResponse.GetResponseStream();
            }

            if (stream.CanSeek) {
                // if we can get data synchronously, then get it
                LoadStream(true);
            } else {
                // the data can't be loaded synchronously
                // load it async, then wait for it to finish
                doesLoadAppearSynchronous = true; // to avoid OnFailed call.
                LoadStream(false);

                if(!semaphore.WaitOne(LoadTimeout, false)) {
                    if (copyThread != null)
                        copyThread.Abort();
                    CleanupStreamData();
                    throw new TimeoutException(SR.SoundAPILoadTimedOut);
                }

                doesLoadAppearSynchronous = false;
                
                if (lastLoadException != null)
                {
                    throw lastLoadException;
                }
            }

            // we don't need the worker copyThread anymore
            this.copyThread = null;
        }

        private void LoadStream(bool loadSync) {
            if (loadSync && stream.CanSeek) {
                int streamLen = (int) stream.Length;
                currentPos = 0;
                streamData = new byte[streamLen];
                stream.Read(streamData, 0, streamLen);
                isLoadCompleted = true;
                OnLoadCompleted(new AsyncCompletedEventArgs(null, false, null));
            } else {
                // lock any synchronous calls on the Sound object
                semaphore.Reset();
                // start loading
                copyThread = new Thread(new ThreadStart(this.WorkerThread));
                copyThread.Start();
            }
        }

        public void Play() {
            LoadAndPlay(Interop.WinMM.SND_ASYNC);
        }

        public void PlaySync() {
            LoadAndPlay(Interop.WinMM.SND_SYNC);
        }

        public void PlayLooping() {
            LoadAndPlay(Interop.WinMM.SND_LOOP | Interop.WinMM.SND_ASYNC);
        }

        private static Uri ResolveUri(string partialUri) {
            Uri result = null;
            try {
                result = new Uri(partialUri);
            } catch (UriFormatException) {
                // eat URI parse exceptions
            }

            if (result == null) {
                // try relative to appbase
                try {
                    result = new Uri(Path.GetFullPath(partialUri));
                } catch (UriFormatException) {
                    // eat URI parse exceptions
                }
            }
            return result;
        }

        private void SetupSoundLocation(string soundLocation) {
            // if we are loading a file, stop it right now
            //
            if (copyThread != null) {
                copyThread.Abort();
                CleanupStreamData();
            }

            uri = ResolveUri(soundLocation);

            this.soundLocation = soundLocation;
            stream = null;
            if (uri == null) {
                if (!String.IsNullOrEmpty(soundLocation))
                    throw new UriFormatException(SR.SoundAPIBadSoundLocation);
            } else {
                if (!uri.IsFile) {
                    // we are referencing a web resource ...
                    //

                    // we treat it as a stream...
                    //
                    streamData = null;
                    currentPos = 0;
                    isLoadCompleted = false;
                }
            }
        }

        private void SetupStream(Stream stream) {
            if (this.copyThread != null) {
                copyThread.Abort();
                CleanupStreamData();
            }

            this.stream = stream;
            this.soundLocation = String.Empty;
            this.streamData = null;
            this.currentPos = 0;
            isLoadCompleted = false;
            if (stream != null) {
                uri = null;
            }
        }

        public void Stop() {
            Interop.WinMM.PlaySoundW((byte[]) null, IntPtr.Zero, Interop.WinMM.SND_PURGE);
        }

        public event AsyncCompletedEventHandler LoadCompleted {
            add {
                Events.AddHandler(EventLoadCompleted, value);
            }
            remove {
                Events.RemoveHandler(EventLoadCompleted, value);
            }
        }

        public event EventHandler SoundLocationChanged {
            add {
                Events.AddHandler(EventSoundLocationChanged, value);
            }
            remove {
                Events.RemoveHandler(EventSoundLocationChanged, value);
            }
        }

        public event EventHandler StreamChanged {
            add {
                Events.AddHandler(EventStreamChanged, value);
            }
            remove {
                Events.RemoveHandler(EventStreamChanged, value);
            }
        }

        protected virtual void OnLoadCompleted(AsyncCompletedEventArgs e) {
            AsyncCompletedEventHandler eh = (AsyncCompletedEventHandler) Events[EventLoadCompleted];
            if (eh != null)
            {
                eh(this, e);
            }
        }

        protected virtual void OnSoundLocationChanged(EventArgs e) {
            EventHandler eh = (EventHandler) Events[EventSoundLocationChanged];
            if (eh != null)
            {
                eh(this, e);
            }
        }

        protected virtual void OnStreamChanged(EventArgs e) {
            EventHandler eh = (EventHandler) Events[EventStreamChanged];
            if (eh != null)
            {
                eh(this, e);
            }
        }

        [
            SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")   // The set of reasons why WorkerThread should fail is not finite
        ]
        private void WorkerThread() {
            try
            {
                // setup the http stream
                if (uri != null && !uri.IsFile && stream == null) {
                    WebRequest webRequest = WebRequest.Create(uri);

                    WebResponse webResponse = webRequest.GetResponse();

                    stream = webResponse.GetResponseStream();
                }

                this.streamData = new byte[blockSize];

                int readBytes = stream.Read(streamData, currentPos, blockSize);
                int totalBytes = readBytes;

                while (readBytes > 0) {
                    currentPos += readBytes;
                    if (streamData.Length < currentPos + blockSize) {
                        byte[] newData = new byte[streamData.Length * 2];
                        Array.Copy(streamData, newData, streamData.Length);
                        streamData = newData;
                    }
                    readBytes = stream.Read(streamData, currentPos, blockSize);
                    totalBytes += readBytes;
                }

                lastLoadException = null;
            }
            catch (Exception exception)
            {
                lastLoadException = exception;
            }

            if (!doesLoadAppearSynchronous)
            {
                // Post notification back to the UI thread.
                asyncOperation.PostOperationCompleted(
                    loadAsyncOperationCompleted,
                    new AsyncCompletedEventArgs(lastLoadException, false, null));
            }
            isLoadCompleted = true;
            semaphore.Set();
        }

        private unsafe void ValidateSoundFile(string fileName) {
            Interop.WinMM.MMCKINFO ckRIFF = new Interop.WinMM.MMCKINFO();
            Interop.WinMM.MMCKINFO ck = new Interop.WinMM.MMCKINFO();
            Interop.WinMM.WAVEFORMATEX waveFormat = null;
            int dw;

            IntPtr hMIO = Interop.WinMM.mmioOpenW(fileName, IntPtr.Zero, Interop.WinMM.MMIO_READ | Interop.WinMM.MMIO_ALLOCBUF);

            if (hMIO == IntPtr.Zero)
                throw new FileNotFoundException(SR.SoundAPIFileDoesNotExist, this.soundLocation);

            try {
                ckRIFF.fccType = mmioFOURCC('W', 'A','V','E');
                if (Interop.WinMM.mmioDescend(hMIO, ckRIFF, null, Interop.WinMM.MMIO_FINDRIFF) != 0)
                    throw new InvalidOperationException(SR.Format(SR.SoundAPIInvalidWaveFile, this.soundLocation));

                while (Interop.WinMM.mmioDescend(hMIO, ck, ckRIFF, 0) == 0) {
                    if (ck.dwDataOffset + ck.cksize > ckRIFF.dwDataOffset + ckRIFF.cksize)
                        throw new InvalidOperationException(SR.SoundAPIInvalidWaveHeader);

                    if (ck.ckID == mmioFOURCC('f','m','t',' ')) {
                            if (waveFormat == null) {
                                dw = ck.cksize;
                                if (dw < Marshal.SizeOf(typeof(Interop.WinMM.WAVEFORMATEX)))
                                    dw =  Marshal.SizeOf(typeof(Interop.WinMM.WAVEFORMATEX));

                                waveFormat = new Interop.WinMM.WAVEFORMATEX();
                                byte[] data = new byte[dw];
                                if (Interop.WinMM.mmioRead(hMIO, data, dw) != dw)
                                    throw new InvalidOperationException(SR.Format(SR.SoundAPIReadError, this.soundLocation));
                                fixed(byte* pdata = data) {
                                    Marshal.PtrToStructure((IntPtr) pdata, waveFormat);
                                }
                            } else {
                                //
                                // multiple formats?
                                //
                            }
                    }
                    Interop.WinMM.mmioAscend(hMIO, ck, 0);
                }

                if (waveFormat == null)
                    throw new InvalidOperationException(SR.SoundAPIInvalidWaveHeader);

                if (waveFormat.wFormatTag != Interop.WinMM.WAVE_FORMAT_PCM &&
                    waveFormat.wFormatTag != Interop.WinMM.WAVE_FORMAT_ADPCM &&
                    waveFormat.wFormatTag != Interop.WinMM.WAVE_FORMAT_IEEE_FLOAT)
                    throw new InvalidOperationException(SR.SoundAPIFormatNotSupported);

            } finally {
                    if (hMIO != IntPtr.Zero)
                        Interop.WinMM.mmioClose(hMIO, 0);
            }
        }

        private static void ValidateSoundData(byte[] data) {
            int position = 0;
            Int16 wFormatTag = -1;
            bool fmtChunkFound = false;

            // the RIFF header should be at least 12 bytes long.
            if (data.Length < 12)
                throw new System.InvalidOperationException(SR.SoundAPIInvalidWaveHeader);

            // validate the RIFF header
            if (data[0] != 'R' || data[1] != 'I' || data[2] != 'F' || data[3] != 'F')
                throw new System.InvalidOperationException(SR.SoundAPIInvalidWaveHeader);
            if (data[8] != 'W' || data[9] != 'A' || data[10] != 'V' || data[11] != 'E')
                throw new System.InvalidOperationException(SR.SoundAPIInvalidWaveHeader);

            // we only care about "fmt " chunk
            position = 12;
            int len = data.Length;
            while (!fmtChunkFound && position < len - 8) {
                if (data[position] == (byte)'f' && data[position + 1] == (byte)'m' && data[position + 2] == (byte)'t' && data[position+3] == (byte)' ') {
                    //
                    // fmt chunk
                    //
                    fmtChunkFound = true;
                    int chunkSize = BytesToInt(data[position+7], data[position+6], data[position+5], data[position+4]);
                    //
                    // get the cbSize from the WAVEFORMATEX
                    //

                    int sizeOfWAVEFORMAT = 16;
                    if (chunkSize != sizeOfWAVEFORMAT) {
                        // we are dealing w/ WAVEFORMATEX
                        // do extra validation
                        int sizeOfWAVEFORMATEX = 18;

                        // make sure the buffer is big enough to store a short
                        if (len < position + 8 + sizeOfWAVEFORMATEX - 1)
                            throw new System.InvalidOperationException(SR.SoundAPIInvalidWaveHeader);

                        Int16 cbSize = BytesToInt16(data[position+8 + sizeOfWAVEFORMATEX - 1],
                                                    data[position+8 + sizeOfWAVEFORMATEX-2]);
                        if (cbSize + sizeOfWAVEFORMATEX != chunkSize)
                            throw new System.InvalidOperationException(SR.SoundAPIInvalidWaveHeader);
                    }

                    // make sure the buffer passed in is big enough to store a short
                    if(len < position + 9)
                        throw new System.InvalidOperationException(SR.SoundAPIInvalidWaveHeader);
                    wFormatTag = BytesToInt16(data[position+9], data[position+8]);

                    position += chunkSize + 8;
                } else {
                    position += 8 + BytesToInt(data[position+7], data[position+6], data[position+5], data[position+4]);
                }
            }

            if (!fmtChunkFound)
                throw new System.InvalidOperationException(SR.SoundAPIInvalidWaveHeader);

            if (wFormatTag != Interop.WinMM.WAVE_FORMAT_PCM &&
                wFormatTag != Interop.WinMM.WAVE_FORMAT_ADPCM &&
                wFormatTag != Interop.WinMM.WAVE_FORMAT_IEEE_FLOAT)
                throw new System.InvalidOperationException(SR.SoundAPIFormatNotSupported);
        }

        private static Int16 BytesToInt16(byte ch0, byte ch1) {
            int res;
            res = (int) ch1;
            res |= (int) (((int)ch0) << 8);
            return (Int16) res;
        }
        private static int BytesToInt(byte ch0, byte ch1, byte ch2, byte ch3) {
            return mmioFOURCC((char) ch3, (char)ch2, (char) ch1, (char)ch0);
        }

        private static int mmioFOURCC(char ch0, char ch1, char ch2, char ch3) {
            int result = 0;
            result |= ((int) ch0);
            result |= ((int) ch1) << 8;
            result |= ((int) ch2) << 16;
            result |= ((int) ch3) << 24;
            return result;
        }

        [SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")] // vsw 427356
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {
            if (!String.IsNullOrEmpty(this.soundLocation)) {
                info.AddValue("SoundLocation", this.soundLocation);
            }

            if (this.stream != null) {
                info.AddValue("Stream", this.stream);
            }

            info.AddValue("LoadTimeout", this.loadTimeout);
        }
    }
}
