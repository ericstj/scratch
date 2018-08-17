// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Threading;
using Xunit;

namespace System.Media.SoundPlayerTests
{
    public class SoundPlayerTests
    {
        internal static string localWavFile = Environment.ExpandEnvironmentVariables(@"%WINDIR%\media\tada.wav");
        internal const int loadWait = 10000;

        [Fact]
        public void Defaults()
        {

            var player = new SoundPlayer();

            Assert.False(player.IsLoadCompleted);
            Assert.Null(player.Container);
            Assert.Null(player.Site);
            Assert.NotNull(player.SoundLocation);
            Assert.Equal(0, player.SoundLocation.Length);
            Assert.Null(player.Stream);
            Assert.Null(player.Tag);
            Assert.Equal(10000, player.LoadTimeout);

        }

        [Fact]
        public void LoadSyncPath()
        {
            var player = new SoundPlayer(localWavFile);
            object eventObject = null;
            AsyncCompletedEventArgs eventArgs = null;
            player.LoadCompleted += (o, e) =>
            {
                eventObject = o;
                eventArgs = e;
            };

            player.Load();
            Assert.NotNull(eventArgs);
            Assert.False(eventArgs.Cancelled);
            Assert.Null(eventArgs.Error);
            Assert.Null(eventArgs.UserState);
            Assert.Same(player, eventObject);
            Assert.True(player.IsLoadCompleted);
        }

        // async
        [Fact]
        public void LoadAsyncPath()
        {
            var player = new SoundPlayer(localWavFile);
            object eventObject = null;
            AsyncCompletedEventArgs eventArgs = null;
            var signal = new AutoResetEvent(false);
            player.LoadCompleted += (o, e) =>
            {
                eventObject = o;
                eventArgs = e;
                signal.Set();
            };
            
            var semaphoreField = player.GetType().GetField("_semaphore", BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.NotNull(semaphoreField);
            ManualResetEvent internalSemaphore = (ManualResetEvent)semaphoreField.GetValue(player);
            Assert.NotNull(internalSemaphore);

            player.LoadAsync();
            Assert.True(signal.WaitOne(loadWait));
            Assert.NotNull(eventArgs);
            Assert.False(eventArgs.Cancelled);
            Assert.Null(eventArgs.Error);
            Assert.Null(eventArgs.UserState);
            Assert.Same(player, eventObject);

            // IsLoadCompleted is set by a worker thread, which may still be running.  Wait for it to signal.
            Assert.True(internalSemaphore.WaitOne(loadWait));
            Assert.True(player.IsLoadCompleted);
        }

        [Fact]
        public void LoadSyncStream()
        {
            using (var stream = File.OpenRead(localWavFile))
            {
                var player = new SoundPlayer(stream);
                object eventObject = null;
                AsyncCompletedEventArgs eventArgs = null;
                player.LoadCompleted += (o, e) =>
                {
                    eventObject = o;
                    eventArgs = e;
                };

                player.Load();
                Assert.NotNull(eventArgs);
                Assert.False(eventArgs.Cancelled);
                Assert.Null(eventArgs.Error);
                Assert.Null(eventArgs.UserState);
                Assert.Same(player, eventObject);
                Assert.True(player.IsLoadCompleted);
            }
        }

        // async
        [Fact]
        public void LoadAsyncStream()
        {
            using (var stream = File.OpenRead(localWavFile))
            {
                var player = new SoundPlayer(stream);
                object eventObject = null;
                AsyncCompletedEventArgs eventArgs = null;
                var signal = new AutoResetEvent(false);
                player.LoadCompleted += (o, e) =>
                {
                    eventObject = o;
                    eventArgs = e;
                    signal.Set();
                };

                player.LoadAsync();
                Assert.True(signal.WaitOne(loadWait));
                Assert.NotNull(eventArgs);
                Assert.False(eventArgs.Cancelled);
                Assert.Null(eventArgs.Error);
                Assert.Null(eventArgs.UserState);
                Assert.Same(player, eventObject);
                Assert.True(player.IsLoadCompleted);
            }
        }

        // exception

        [Fact]
        public void ThrowsSynchronouslyOnMissingFile()
        {
            var noExist = "file_does_not_exist.wav";
            var player = new SoundPlayer(noExist);
            var fnf = Assert.Throws<FileNotFoundException>(() => player.Load());
            Assert.Equal(noExist, fnf.FileName);

            fnf = Assert.Throws<FileNotFoundException>(() => player.LoadAsync());
            Assert.Equal(noExist, fnf.FileName);
        }

        internal class TestStream : Stream
        {
            public TestStream(long length)
            {
                Length = length;
            }

            public override bool CanRead => true;

            public override bool CanSeek => false;

            public override bool CanWrite => false;

            public override long Length { get; }

            public override long Position
            {
                get => 0;
                set { throw new NotSupportedException(); }
            }

            public override void Flush()
            { }

            public override int Read(byte[] buffer, int offset, int count)
            {
                throw new NotSupportedException();
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                throw new NotSupportedException();
            }

            public override void SetLength(long value)
            {
                throw new NotSupportedException();
            }

            public override void Write(byte[] buffer, int offset, int count)
            {
                throw new NotSupportedException();
            }
        }

        [Fact]
        public void ThrowsOnLoadBadStream()
        {
            var player = new SoundPlayer(new TestStream(10));

            Assert.Throws<NotSupportedException>(() => player.Load());
            Assert.True(player.IsLoadCompleted);
        }

        [Fact]
        public void EventOnLoadAsyncBadStream()
        { 
            var player = new SoundPlayer(new TestStream(10));
            object eventObject = null;
            AsyncCompletedEventArgs eventArgs = null;
            var signal = new AutoResetEvent(false);
            player.LoadCompleted += (o, e) =>
            {
                eventObject = o;
                eventArgs = e;
                signal.Set();
            };

            player.LoadAsync();
            Assert.True(signal.WaitOne(loadWait));
            Assert.NotNull(eventArgs);
            Assert.False(eventArgs.Cancelled);
            Assert.NotNull(eventArgs.Error);
            Assert.IsType<NotSupportedException>(eventArgs.Error);
            Assert.Null(eventArgs.UserState);
            Assert.Same(player, eventObject);
            Assert.True(player.IsLoadCompleted);
        }

        [Fact]
        public void SoundLocationChanged()
        {
            var player = new SoundPlayer(localWavFile);
            object eventObject = null;
            EventArgs eventArgs = null;
            bool eventFired = false;
            player.SoundLocationChanged += (o, e) =>
            {
                eventObject = o;
                eventArgs = e;
                eventFired = true;
            };

            player.SoundLocation = player.SoundLocation;
            Assert.Null(eventObject);
            Assert.Null(eventArgs);
            Assert.False(eventFired);

            player.SoundLocation = "abc.wav";
            Assert.True(eventFired);
            Assert.Same(eventObject, player);
            Assert.Same(EventArgs.Empty, eventArgs);
        }


        [Fact]
        public void StreamChanged()
        {
            var player = new SoundPlayer(new TestStream(10));
            object eventObject = null;
            EventArgs eventArgs = null;
            bool eventFired = false;
            player.StreamChanged += (o, e) =>
            {
                eventObject = o;
                eventArgs = e;
                eventFired = true;
            };

            player.Stream = player.Stream;
            Assert.Null(eventObject);
            Assert.Null(eventArgs);
            Assert.False(eventFired);

            player.Stream = null;
            Assert.True(eventFired);
            Assert.Same(eventObject, player);
            Assert.Same(EventArgs.Empty, eventArgs);
        }


        [Fact]
        public void PlaysLocalSound()
        {

            var player = new SoundPlayer(localWavFile);
            Assert.Equal(localWavFile, player.SoundLocation);

            player.Play();

            Assert.True(player.IsLoadCompleted);
        }

        [Fact]
        public void PlaysLocalSoundLooping()
        {
            var player = new SoundPlayer(localWavFile);

            player.PlayLooping();
            Assert.True(player.IsLoadCompleted);
            player.Stop();
        }
    }
}
