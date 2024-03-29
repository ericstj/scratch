// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// ------------------------------------------------------------------------------
// Changes to this file must follow the https://aka.ms/api-review process.
// ------------------------------------------------------------------------------

namespace System.Speech.AudioFormat
{
    public enum AudioBitsPerSample
    {
        Eight = 8,
        Sixteen = 16,
    }
    public enum AudioChannel
    {
        Mono = 1,
        Stereo = 2,
    }
    public enum EncodingFormat
    {
        Pcm = 1,
        ALaw = 6,
        ULaw = 7,
    }
    public partial class SpeechAudioFormatInfo
    {
        public SpeechAudioFormatInfo(int samplesPerSecond, System.Speech.AudioFormat.AudioBitsPerSample bitsPerSample, System.Speech.AudioFormat.AudioChannel channel) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public SpeechAudioFormatInfo(System.Speech.AudioFormat.EncodingFormat encodingFormat, int samplesPerSecond, int bitsPerSample, int channelCount, int averageBytesPerSecond, int blockAlign, byte[] formatSpecificData) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public int AverageBytesPerSecond { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public int BitsPerSample { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public int BlockAlign { get { throw null; } }
        public int ChannelCount { get { throw null; } }
        public System.Speech.AudioFormat.EncodingFormat EncodingFormat { get { throw null; } }
        public int SamplesPerSecond { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public byte[] FormatSpecificData() { throw null; }
        public override int GetHashCode() { throw null; }
    }
}
namespace System.Speech.Recognition
{
    public partial class AudioLevelUpdatedEventArgs : System.EventArgs
    {
        internal AudioLevelUpdatedEventArgs() { }
        public int AudioLevel { get { throw null; } }
    }
    public enum AudioSignalProblem
    {
        None = 0,
        TooNoisy = 1,
        NoSignal = 2,
        TooLoud = 3,
        TooSoft = 4,
        TooFast = 5,
        TooSlow = 6,
    }
    public partial class AudioSignalProblemOccurredEventArgs : System.EventArgs
    {
        internal AudioSignalProblemOccurredEventArgs() { }
        public int AudioLevel { get { throw null; } }
        public System.TimeSpan AudioPosition { get { throw null; } }
        public System.Speech.Recognition.AudioSignalProblem AudioSignalProblem { get { throw null; } }
        public System.TimeSpan RecognizerAudioPosition { get { throw null; } }
    }
    public enum AudioState
    {
        Stopped = 0,
        Silence = 1,
        Speech = 2,
    }
    public partial class AudioStateChangedEventArgs : System.EventArgs
    {
        internal AudioStateChangedEventArgs() { }
        public System.Speech.Recognition.AudioState AudioState { get { throw null; } }
    }
    public partial class Choices
    {
        public Choices() { }
        public Choices(params System.Speech.Recognition.GrammarBuilder[] alternateChoices) { }
        public Choices(params string[] phrases) { }
        public void Add(params System.Speech.Recognition.GrammarBuilder[] alternateChoices) { }
        public void Add(params string[] phrases) { }
        public System.Speech.Recognition.GrammarBuilder ToGrammarBuilder() { throw null; }
    }
    public partial class DictationGrammar : System.Speech.Recognition.Grammar
    {
        public DictationGrammar() { }
        public DictationGrammar(string topic) { }
        public void SetDictationContext(string precedingText, string subsequentText) { }
    }
    [System.FlagsAttribute]
    public enum DisplayAttributes
    {
        None = 0,
        ZeroTrailingSpaces = 2,
        OneTrailingSpace = 4,
        TwoTrailingSpaces = 8,
        ConsumeLeadingSpaces = 16,
    }
    public partial class EmulateRecognizeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal EmulateRecognizeCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public System.Speech.Recognition.RecognitionResult Result { get { throw null; } }
    }
    public partial class Grammar
    {
        protected Grammar() { }
        public Grammar(System.IO.Stream stream) { }
        public Grammar(System.IO.Stream stream, string ruleName) { }
        public Grammar(System.IO.Stream stream, string ruleName, object[] parameters) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public Grammar(System.IO.Stream stream, string ruleName, System.Uri baseUri) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public Grammar(System.IO.Stream stream, string ruleName, System.Uri baseUri, object[] parameters) { }
        public Grammar(System.Speech.Recognition.GrammarBuilder builder) { }
        public Grammar(System.Speech.Recognition.SrgsGrammar.SrgsDocument srgsDocument) { }
        public Grammar(System.Speech.Recognition.SrgsGrammar.SrgsDocument srgsDocument, string ruleName) { }
        public Grammar(System.Speech.Recognition.SrgsGrammar.SrgsDocument srgsDocument, string ruleName, object[] parameters) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public Grammar(System.Speech.Recognition.SrgsGrammar.SrgsDocument srgsDocument, string ruleName, System.Uri baseUri) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public Grammar(System.Speech.Recognition.SrgsGrammar.SrgsDocument srgsDocument, string ruleName, System.Uri baseUri, object[] parameters) { }
        public Grammar(string path) { }
        public Grammar(string path, string ruleName) { }
        public Grammar(string path, string ruleName, object[] parameters) { }
        public bool Enabled { get { throw null; } set { } }
        protected internal virtual bool IsStg { get { throw null; } }
        public bool Loaded { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public int Priority { get { throw null; } set { } }
        protected string ResourceName { get { throw null; } set { } }
        public string RuleName { get { throw null; } }
        public float Weight { get { throw null; } set { } }
        public event System.EventHandler<System.Speech.Recognition.SpeechRecognizedEventArgs> SpeechRecognized { add { } remove { } }
        public static System.Speech.Recognition.Grammar LoadLocalizedGrammarFromType(System.Type type, params object[] onInitParameters) { throw null; }
        protected void StgInit(object[] parameters) { }
    }
    public partial class GrammarBuilder
    {
        public GrammarBuilder() { }
        public GrammarBuilder(System.Speech.Recognition.Choices alternateChoices) { }
        public GrammarBuilder(System.Speech.Recognition.GrammarBuilder builder, int minRepeat, int maxRepeat) { }
        public GrammarBuilder(System.Speech.Recognition.SemanticResultKey key) { }
        public GrammarBuilder(System.Speech.Recognition.SemanticResultValue value) { }
        public GrammarBuilder(string phrase) { }
        public GrammarBuilder(string phrase, int minRepeat, int maxRepeat) { }
        public GrammarBuilder(string phrase, System.Speech.Recognition.SubsetMatchingMode subsetMatchingCriteria) { }
        public System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        public string DebugShowPhrases { get { throw null; } }
        public static System.Speech.Recognition.GrammarBuilder Add(System.Speech.Recognition.Choices choices, System.Speech.Recognition.GrammarBuilder builder) { throw null; }
        public static System.Speech.Recognition.GrammarBuilder Add(System.Speech.Recognition.GrammarBuilder builder, System.Speech.Recognition.Choices choices) { throw null; }
        public static System.Speech.Recognition.GrammarBuilder Add(System.Speech.Recognition.GrammarBuilder builder1, System.Speech.Recognition.GrammarBuilder builder2) { throw null; }
        public static System.Speech.Recognition.GrammarBuilder Add(System.Speech.Recognition.GrammarBuilder builder, string phrase) { throw null; }
        public static System.Speech.Recognition.GrammarBuilder Add(string phrase, System.Speech.Recognition.GrammarBuilder builder) { throw null; }
        public void Append(System.Speech.Recognition.Choices alternateChoices) { }
        public void Append(System.Speech.Recognition.GrammarBuilder builder) { }
        public void Append(System.Speech.Recognition.GrammarBuilder builder, int minRepeat, int maxRepeat) { }
        public void Append(System.Speech.Recognition.SemanticResultKey key) { }
        public void Append(System.Speech.Recognition.SemanticResultValue value) { }
        public void Append(string phrase) { }
        public void Append(string phrase, int minRepeat, int maxRepeat) { }
        public void Append(string phrase, System.Speech.Recognition.SubsetMatchingMode subsetMatchingCriteria) { }
        public void AppendDictation() { }
        public void AppendDictation(string category) { }
        public void AppendRuleReference(string path) { }
        public void AppendRuleReference(string path, string rule) { }
        public void AppendWildcard() { }
        public static System.Speech.Recognition.GrammarBuilder operator +(System.Speech.Recognition.Choices choices, System.Speech.Recognition.GrammarBuilder builder) { throw null; }
        public static System.Speech.Recognition.GrammarBuilder operator +(System.Speech.Recognition.GrammarBuilder builder, System.Speech.Recognition.Choices choices) { throw null; }
        public static System.Speech.Recognition.GrammarBuilder operator +(System.Speech.Recognition.GrammarBuilder builder1, System.Speech.Recognition.GrammarBuilder builder2) { throw null; }
        public static System.Speech.Recognition.GrammarBuilder operator +(System.Speech.Recognition.GrammarBuilder builder, string phrase) { throw null; }
        public static System.Speech.Recognition.GrammarBuilder operator +(string phrase, System.Speech.Recognition.GrammarBuilder builder) { throw null; }
        public static implicit operator System.Speech.Recognition.GrammarBuilder (System.Speech.Recognition.Choices choices) { throw null; }
        public static implicit operator System.Speech.Recognition.GrammarBuilder (System.Speech.Recognition.SemanticResultKey semanticKey) { throw null; }
        public static implicit operator System.Speech.Recognition.GrammarBuilder (System.Speech.Recognition.SemanticResultValue semanticValue) { throw null; }
        public static implicit operator System.Speech.Recognition.GrammarBuilder (string phrase) { throw null; }
    }
    public partial class LoadGrammarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal LoadGrammarCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public System.Speech.Recognition.Grammar Grammar { get { throw null; } }
    }
    public abstract partial class RecognitionEventArgs : System.EventArgs
    {
        internal RecognitionEventArgs() { }
        public System.Speech.Recognition.RecognitionResult Result { get { throw null; } }
    }
    public sealed partial class RecognitionResult : System.Speech.Recognition.RecognizedPhrase, System.Runtime.Serialization.ISerializable
    {
        internal RecognitionResult() { }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.RecognizedPhrase> Alternates { get { throw null; } }
        public System.Speech.Recognition.RecognizedAudio Audio { get { throw null; } }
        public System.Speech.Recognition.RecognizedAudio GetAudioForWordRange(System.Speech.Recognition.RecognizedWordUnit firstWord, System.Speech.Recognition.RecognizedWordUnit lastWord) { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class RecognizeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal RecognizeCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public System.TimeSpan AudioPosition { get { throw null; } }
        public bool BabbleTimeout { get { throw null; } }
        public bool InitialSilenceTimeout { get { throw null; } }
        public bool InputStreamEnded { get { throw null; } }
        public System.Speech.Recognition.RecognitionResult Result { get { throw null; } }
    }
    public partial class RecognizedAudio
    {
        internal RecognizedAudio() { }
        public System.TimeSpan AudioPosition { get { throw null; } }
        public System.TimeSpan Duration { get { throw null; } }
        public System.Speech.AudioFormat.SpeechAudioFormatInfo Format { get { throw null; } }
        public System.DateTime StartTime { get { throw null; } }
        public System.Speech.Recognition.RecognizedAudio GetRange(System.TimeSpan audioPosition, System.TimeSpan duration) { throw null; }
        public void WriteToAudioStream(System.IO.Stream outputStream) { }
        public void WriteToWaveStream(System.IO.Stream outputStream) { }
    }
    public partial class RecognizedPhrase
    {
        internal RecognizedPhrase() { }
        public float Confidence { get { throw null; } }
        public System.Speech.Recognition.Grammar Grammar { get { throw null; } }
        public int HomophoneGroupId { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.RecognizedPhrase> Homophones { get { throw null; } }
        public System.Collections.ObjectModel.Collection<System.Speech.Recognition.ReplacementText> ReplacementWordUnits { get { throw null; } }
        public System.Speech.Recognition.SemanticValue Semantics { get { throw null; } }
        public string Text { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.RecognizedWordUnit> Words { get { throw null; } }
        public System.Xml.XPath.IXPathNavigable ConstructSmlFromSemantics() { throw null; }
    }
    public partial class RecognizedWordUnit
    {
        public RecognizedWordUnit(string text, float confidence, string pronunciation, string lexicalForm, System.Speech.Recognition.DisplayAttributes displayAttributes, System.TimeSpan audioPosition, System.TimeSpan audioDuration) { }
        public float Confidence { get { throw null; } }
        public System.Speech.Recognition.DisplayAttributes DisplayAttributes { get { throw null; } }
        public string LexicalForm { get { throw null; } }
        public string Pronunciation { get { throw null; } }
        public string Text { get { throw null; } }
    }
    public enum RecognizeMode
    {
        Single = 0,
        Multiple = 1,
    }
    public partial class RecognizerInfo : System.IDisposable
    {
        internal RecognizerInfo() { }
        public System.Collections.Generic.IDictionary<string, string> AdditionalInfo { get { throw null; } }
        public System.Globalization.CultureInfo Culture { get { throw null; } }
        public string Description { get { throw null; } }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.AudioFormat.SpeechAudioFormatInfo> SupportedAudioFormats { get { throw null; } }
        public void Dispose() { }
    }
    public enum RecognizerState
    {
        Stopped = 0,
        Listening = 1,
    }
    public partial class RecognizerUpdateReachedEventArgs : System.EventArgs
    {
        internal RecognizerUpdateReachedEventArgs() { }
        public System.TimeSpan AudioPosition { get { throw null; } }
        public object UserToken { get { throw null; } }
    }
    public partial class ReplacementText
    {
        internal ReplacementText() { }
        public int CountOfWords { get { throw null; } }
        public System.Speech.Recognition.DisplayAttributes DisplayAttributes { get { throw null; } }
        public int FirstWordIndex { get { throw null; } }
        public string Text { get { throw null; } }
    }
    public partial class SemanticResultKey
    {
        public SemanticResultKey(string semanticResultKey, params System.Speech.Recognition.GrammarBuilder[] builders) { }
        public SemanticResultKey(string semanticResultKey, params string[] phrases) { }
        public System.Speech.Recognition.GrammarBuilder ToGrammarBuilder() { throw null; }
    }
    public partial class SemanticResultValue
    {
        public SemanticResultValue(object value) { }
        public SemanticResultValue(System.Speech.Recognition.GrammarBuilder builder, object value) { }
        public SemanticResultValue(string phrase, object value) { }
        public System.Speech.Recognition.GrammarBuilder ToGrammarBuilder() { throw null; }
    }
    public sealed partial class SemanticValue : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, System.Speech.Recognition.SemanticValue>>, System.Collections.Generic.IDictionary<string, System.Speech.Recognition.SemanticValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Speech.Recognition.SemanticValue>>, System.Collections.IEnumerable
    {
        public SemanticValue(object value) { }
        public SemanticValue(string keyName, object value, float confidence) { }
        public float Confidence { get { throw null; } }
        public int Count { get { throw null; } }
        public System.Speech.Recognition.SemanticValue this[string key] { get { throw null; } set { } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, System.Speech.Recognition.SemanticValue>>.IsReadOnly { get { throw null; } }
        System.Collections.Generic.ICollection<string> System.Collections.Generic.IDictionary<string, System.Speech.Recognition.SemanticValue>.Keys { get { throw null; } }
        System.Collections.Generic.ICollection<System.Speech.Recognition.SemanticValue> System.Collections.Generic.IDictionary<string, System.Speech.Recognition.SemanticValue>.Values { get { throw null; } }
        public object Value { get { throw null; } }
        public bool Contains(System.Collections.Generic.KeyValuePair<string, System.Speech.Recognition.SemanticValue> item) { throw null; }
        public bool ContainsKey(string key) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, System.Speech.Recognition.SemanticValue>>.Add(System.Collections.Generic.KeyValuePair<string, System.Speech.Recognition.SemanticValue> key) { }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, System.Speech.Recognition.SemanticValue>>.Clear() { }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, System.Speech.Recognition.SemanticValue>>.CopyTo(System.Collections.Generic.KeyValuePair<string, System.Speech.Recognition.SemanticValue>[] array, int index) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, System.Speech.Recognition.SemanticValue>>.Remove(System.Collections.Generic.KeyValuePair<string, System.Speech.Recognition.SemanticValue> key) { throw null; }
        void System.Collections.Generic.IDictionary<string, System.Speech.Recognition.SemanticValue>.Add(string key, System.Speech.Recognition.SemanticValue value) { }
        bool System.Collections.Generic.IDictionary<string, System.Speech.Recognition.SemanticValue>.Remove(string key) { throw null; }
        bool System.Collections.Generic.IDictionary<string, System.Speech.Recognition.SemanticValue>.TryGetValue(string key, out System.Speech.Recognition.SemanticValue value) { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, System.Speech.Recognition.SemanticValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Speech.Recognition.SemanticValue>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SpeechDetectedEventArgs : System.EventArgs
    {
        internal SpeechDetectedEventArgs() { }
        public System.TimeSpan AudioPosition { get { throw null; } }
    }
    public partial class SpeechHypothesizedEventArgs : System.Speech.Recognition.RecognitionEventArgs
    {
        internal SpeechHypothesizedEventArgs() { }
    }
    public partial class SpeechRecognitionEngine : System.IDisposable
    {
        public SpeechRecognitionEngine() { }
        public SpeechRecognitionEngine(System.Globalization.CultureInfo culture) { }
        public SpeechRecognitionEngine(System.Speech.Recognition.RecognizerInfo recognizerInfo) { }
        public SpeechRecognitionEngine(string recognizerId) { }
        public System.Speech.AudioFormat.SpeechAudioFormatInfo AudioFormat { get { throw null; } }
        public int AudioLevel { get { throw null; } }
        public System.TimeSpan AudioPosition { get { throw null; } }
        public System.Speech.Recognition.AudioState AudioState { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.TimeSpan BabbleTimeout { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.TimeSpan EndSilenceTimeout { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.TimeSpan EndSilenceTimeoutAmbiguous { get { throw null; } set { } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.Grammar> Grammars { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.TimeSpan InitialSilenceTimeout { get { throw null; } set { } }
        public int MaxAlternates { get { throw null; } set { } }
        public System.TimeSpan RecognizerAudioPosition { get { throw null; } }
        public System.Speech.Recognition.RecognizerInfo RecognizerInfo { get { throw null; } }
        public event System.EventHandler<System.Speech.Recognition.AudioLevelUpdatedEventArgs> AudioLevelUpdated { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.AudioSignalProblemOccurredEventArgs> AudioSignalProblemOccurred { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.AudioStateChangedEventArgs> AudioStateChanged { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.EmulateRecognizeCompletedEventArgs> EmulateRecognizeCompleted { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.LoadGrammarCompletedEventArgs> LoadGrammarCompleted { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.RecognizeCompletedEventArgs> RecognizeCompleted { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.RecognizerUpdateReachedEventArgs> RecognizerUpdateReached { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.SpeechDetectedEventArgs> SpeechDetected { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.SpeechHypothesizedEventArgs> SpeechHypothesized { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.SpeechRecognitionRejectedEventArgs> SpeechRecognitionRejected { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.SpeechRecognizedEventArgs> SpeechRecognized { add { } remove { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public System.Speech.Recognition.RecognitionResult EmulateRecognize(System.Speech.Recognition.RecognizedWordUnit[] wordUnits, System.Globalization.CompareOptions compareOptions) { throw null; }
        public System.Speech.Recognition.RecognitionResult EmulateRecognize(string inputText) { throw null; }
        public System.Speech.Recognition.RecognitionResult EmulateRecognize(string inputText, System.Globalization.CompareOptions compareOptions) { throw null; }
        public void EmulateRecognizeAsync(System.Speech.Recognition.RecognizedWordUnit[] wordUnits, System.Globalization.CompareOptions compareOptions) { }
        public void EmulateRecognizeAsync(string inputText) { }
        public void EmulateRecognizeAsync(string inputText, System.Globalization.CompareOptions compareOptions) { }
        public static System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.RecognizerInfo> InstalledRecognizers() { throw null; }
        public void LoadGrammar(System.Speech.Recognition.Grammar grammar) { }
        public void LoadGrammarAsync(System.Speech.Recognition.Grammar grammar) { }
        public object QueryRecognizerSetting(string settingName) { throw null; }
        public System.Speech.Recognition.RecognitionResult Recognize() { throw null; }
        public System.Speech.Recognition.RecognitionResult Recognize(System.TimeSpan initialSilenceTimeout) { throw null; }
        public void RecognizeAsync() { }
        public void RecognizeAsync(System.Speech.Recognition.RecognizeMode mode) { }
        public void RecognizeAsyncCancel() { }
        public void RecognizeAsyncStop() { }
        public void RequestRecognizerUpdate() { }
        public void RequestRecognizerUpdate(object userToken) { }
        public void RequestRecognizerUpdate(object userToken, System.TimeSpan audioPositionAheadToRaiseUpdate) { }
        public void SetInputToAudioStream(System.IO.Stream audioSource, System.Speech.AudioFormat.SpeechAudioFormatInfo audioFormat) { }
        public void SetInputToDefaultAudioDevice() { }
        public void SetInputToNull() { }
        public void SetInputToWaveFile(string path) { }
        public void SetInputToWaveStream(System.IO.Stream audioSource) { }
        public void UnloadAllGrammars() { }
        public void UnloadGrammar(System.Speech.Recognition.Grammar grammar) { }
        public void UpdateRecognizerSetting(string settingName, int updatedValue) { }
        public void UpdateRecognizerSetting(string settingName, string updatedValue) { }
    }
    public partial class SpeechRecognitionRejectedEventArgs : System.Speech.Recognition.RecognitionEventArgs
    {
        internal SpeechRecognitionRejectedEventArgs() { }
    }
    public partial class SpeechRecognizedEventArgs : System.Speech.Recognition.RecognitionEventArgs
    {
        internal SpeechRecognizedEventArgs() { }
    }
    public partial class SpeechRecognizer : System.IDisposable
    {
        public SpeechRecognizer() { }
        public System.Speech.AudioFormat.SpeechAudioFormatInfo AudioFormat { get { throw null; } }
        public int AudioLevel { get { throw null; } }
        public System.TimeSpan AudioPosition { get { throw null; } }
        public System.Speech.Recognition.AudioState AudioState { get { throw null; } }
        public bool Enabled { get { throw null; } set { } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.Grammar> Grammars { get { throw null; } }
        public int MaxAlternates { get { throw null; } set { } }
        public bool PauseRecognizerOnRecognition { get { throw null; } set { } }
        public System.TimeSpan RecognizerAudioPosition { get { throw null; } }
        public System.Speech.Recognition.RecognizerInfo RecognizerInfo { get { throw null; } }
        public System.Speech.Recognition.RecognizerState State { get { throw null; } }
        public event System.EventHandler<System.Speech.Recognition.AudioLevelUpdatedEventArgs> AudioLevelUpdated { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.AudioSignalProblemOccurredEventArgs> AudioSignalProblemOccurred { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.AudioStateChangedEventArgs> AudioStateChanged { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.EmulateRecognizeCompletedEventArgs> EmulateRecognizeCompleted { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.LoadGrammarCompletedEventArgs> LoadGrammarCompleted { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.RecognizerUpdateReachedEventArgs> RecognizerUpdateReached { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.SpeechDetectedEventArgs> SpeechDetected { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.SpeechHypothesizedEventArgs> SpeechHypothesized { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.SpeechRecognitionRejectedEventArgs> SpeechRecognitionRejected { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.SpeechRecognizedEventArgs> SpeechRecognized { add { } remove { } }
        public event System.EventHandler<System.Speech.Recognition.StateChangedEventArgs> StateChanged { add { } remove { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public System.Speech.Recognition.RecognitionResult EmulateRecognize(System.Speech.Recognition.RecognizedWordUnit[] wordUnits, System.Globalization.CompareOptions compareOptions) { throw null; }
        public System.Speech.Recognition.RecognitionResult EmulateRecognize(string inputText) { throw null; }
        public System.Speech.Recognition.RecognitionResult EmulateRecognize(string inputText, System.Globalization.CompareOptions compareOptions) { throw null; }
        public void EmulateRecognizeAsync(System.Speech.Recognition.RecognizedWordUnit[] wordUnits, System.Globalization.CompareOptions compareOptions) { }
        public void EmulateRecognizeAsync(string inputText) { }
        public void EmulateRecognizeAsync(string inputText, System.Globalization.CompareOptions compareOptions) { }
        public void LoadGrammar(System.Speech.Recognition.Grammar grammar) { }
        public void LoadGrammarAsync(System.Speech.Recognition.Grammar grammar) { }
        public void RequestRecognizerUpdate() { }
        public void RequestRecognizerUpdate(object userToken) { }
        public void RequestRecognizerUpdate(object userToken, System.TimeSpan audioPositionAheadToRaiseUpdate) { }
        public void UnloadAllGrammars() { }
        public void UnloadGrammar(System.Speech.Recognition.Grammar grammar) { }
    }
    public partial class SpeechUI
    {
        internal SpeechUI() { }
        public static bool SendTextFeedback(System.Speech.Recognition.RecognitionResult result, string feedback, bool isSuccessfulAction) { throw null; }
    }
    public partial class StateChangedEventArgs : System.EventArgs
    {
        internal StateChangedEventArgs() { }
        public System.Speech.Recognition.RecognizerState RecognizerState { get { throw null; } }
    }
    public enum SubsetMatchingMode
    {
        Subsequence = 0,
        OrderedSubset = 1,
        SubsequenceContentRequired = 2,
        OrderedSubsetContentRequired = 3,
    }
}
namespace System.Speech.Recognition.SrgsGrammar
{
    public partial class SrgsDocument
    {
        public SrgsDocument() { }
        public SrgsDocument(System.Speech.Recognition.GrammarBuilder builder) { }
        public SrgsDocument(System.Speech.Recognition.SrgsGrammar.SrgsRule grammarRootRule) { }
        public SrgsDocument(string path) { }
        public SrgsDocument(System.Xml.XmlReader srgsGrammar) { }
        public System.Collections.ObjectModel.Collection<string> AssemblyReferences { get { throw null; } }
        public System.Collections.ObjectModel.Collection<string> CodeBehind { get { throw null; } }
        public System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        public bool Debug { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<string> ImportNamespaces { get { throw null; } }
        public string Language { get { throw null; } set { } }
        public System.Speech.Recognition.SrgsGrammar.SrgsGrammarMode Mode { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public System.Speech.Recognition.SrgsGrammar.SrgsPhoneticAlphabet PhoneticAlphabet { get { throw null; } set { } }
        public System.Speech.Recognition.SrgsGrammar.SrgsRule Root { get { throw null; } set { } }
        public System.Speech.Recognition.SrgsGrammar.SrgsRulesCollection Rules { get { throw null; } }
        public string Script { get { throw null; } set { } }
        public System.Uri XmlBase { get { throw null; } set { } }
        public void WriteSrgs(System.Xml.XmlWriter srgsGrammar) { }
    }
    public abstract partial class SrgsElement : System.MarshalByRefObject
    {
        protected SrgsElement() { }
        internal abstract string DebuggerDisplayString();
        internal abstract void WriteSrgs(System.Xml.XmlWriter writer);
    }
    public static partial class SrgsGrammarCompiler
    {
        public static void Compile(System.Speech.Recognition.SrgsGrammar.SrgsDocument srgsGrammar, System.IO.Stream outputStream) { }
        public static void Compile(string inputPath, System.IO.Stream outputStream) { }
        public static void Compile(System.Xml.XmlReader reader, System.IO.Stream outputStream) { }
        public static void CompileClassLibrary(System.Speech.Recognition.SrgsGrammar.SrgsDocument srgsGrammar, string outputPath, string[] referencedAssemblies, string keyFile) { }
        public static void CompileClassLibrary(string[] inputPaths, string outputPath, string[] referencedAssemblies, string keyFile) { }
        public static void CompileClassLibrary(System.Xml.XmlReader reader, string outputPath, string[] referencedAssemblies, string keyFile) { }
    }
    public enum SrgsGrammarMode
    {
        Voice = 0,
        Dtmf = 1,
    }
    public partial class SrgsItem : System.Speech.Recognition.SrgsGrammar.SrgsElement
    {
        public SrgsItem() { }
        public SrgsItem(int repeatCount) { }
        public SrgsItem(int min, int max) { }
        public SrgsItem(int min, int max, params System.Speech.Recognition.SrgsGrammar.SrgsElement[] elements) { }
        public SrgsItem(int min, int max, string text) { }
        public SrgsItem(params System.Speech.Recognition.SrgsGrammar.SrgsElement[] elements) { }
        public SrgsItem(string text) { }
        public System.Collections.ObjectModel.Collection<System.Speech.Recognition.SrgsGrammar.SrgsElement> Elements { get { throw null; } }
        public int MaxRepeat { get { throw null; } }
        public int MinRepeat { get { throw null; } }
        public float RepeatProbability { get { throw null; } set { } }
        public float Weight { get { throw null; } set { } }
        public void Add(System.Speech.Recognition.SrgsGrammar.SrgsElement element) { }
        public void SetRepeat(int count) { }
        public void SetRepeat(int minRepeat, int maxRepeat) { }
    }
    public partial class SrgsNameValueTag : System.Speech.Recognition.SrgsGrammar.SrgsElement
    {
        public SrgsNameValueTag() { }
        public SrgsNameValueTag(object value) { }
        public SrgsNameValueTag(string name, object value) { }
        public string Name { get { throw null; } set { } }
        public object Value { get { throw null; } set { } }
    }
    public partial class SrgsOneOf : System.Speech.Recognition.SrgsGrammar.SrgsElement
    {
        public SrgsOneOf() { }
        public SrgsOneOf(params System.Speech.Recognition.SrgsGrammar.SrgsItem[] items) { }
        public SrgsOneOf(params string[] items) { }
        public System.Collections.ObjectModel.Collection<System.Speech.Recognition.SrgsGrammar.SrgsItem> Items { get { throw null; } }
        public void Add(System.Speech.Recognition.SrgsGrammar.SrgsItem item) { }
    }
    public enum SrgsPhoneticAlphabet
    {
        Sapi = 0,
        Ipa = 1,
        Ups = 2,
    }
    public partial class SrgsRule
    {
        public SrgsRule(string id) { }
        public SrgsRule(string id, params System.Speech.Recognition.SrgsGrammar.SrgsElement[] elements) { }
        public string BaseClass { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.Speech.Recognition.SrgsGrammar.SrgsElement> Elements { get { throw null; } }
        public string Id { get { throw null; } set { } }
        public string OnError { get { throw null; } set { } }
        public string OnInit { get { throw null; } set { } }
        public string OnParse { get { throw null; } set { } }
        public string OnRecognition { get { throw null; } set { } }
        public System.Speech.Recognition.SrgsGrammar.SrgsRuleScope Scope { get { throw null; } set { } }
        public string Script { get { throw null; } set { } }
        public void Add(System.Speech.Recognition.SrgsGrammar.SrgsElement element) { }
    }
    [System.ComponentModel.ImmutableObjectAttribute(true)]
    public partial class SrgsRuleRef : System.Speech.Recognition.SrgsGrammar.SrgsElement
    {
        public static readonly System.Speech.Recognition.SrgsGrammar.SrgsRuleRef Dictation;
        public static readonly System.Speech.Recognition.SrgsGrammar.SrgsRuleRef Garbage;
        public static readonly System.Speech.Recognition.SrgsGrammar.SrgsRuleRef MnemonicSpelling;
        public static readonly System.Speech.Recognition.SrgsGrammar.SrgsRuleRef Null;
        public static readonly System.Speech.Recognition.SrgsGrammar.SrgsRuleRef Void;
        public SrgsRuleRef(System.Speech.Recognition.SrgsGrammar.SrgsRule rule) { }
        public SrgsRuleRef(System.Speech.Recognition.SrgsGrammar.SrgsRule rule, string semanticKey) { }
        public SrgsRuleRef(System.Speech.Recognition.SrgsGrammar.SrgsRule rule, string semanticKey, string parameters) { }
        public SrgsRuleRef(System.Uri uri) { }
        public SrgsRuleRef(System.Uri uri, string rule) { }
        public SrgsRuleRef(System.Uri uri, string rule, string semanticKey) { }
        public SrgsRuleRef(System.Uri uri, string rule, string semanticKey, string parameters) { }
        public string Params { get { throw null; } }
        public string SemanticKey { get { throw null; } }
        public System.Uri Uri { get { throw null; } }
    }
    public sealed partial class SrgsRulesCollection : System.Collections.ObjectModel.KeyedCollection<string, System.Speech.Recognition.SrgsGrammar.SrgsRule>
    {
        public SrgsRulesCollection() { }
        public void Add(params System.Speech.Recognition.SrgsGrammar.SrgsRule[] rules) { }
        protected override string GetKeyForItem(System.Speech.Recognition.SrgsGrammar.SrgsRule rule) { throw null; }
    }
    public enum SrgsRuleScope
    {
        Public = 0,
        Private = 1,
    }
    public partial class SrgsSemanticInterpretationTag : System.Speech.Recognition.SrgsGrammar.SrgsElement
    {
        public SrgsSemanticInterpretationTag() { }
        public SrgsSemanticInterpretationTag(string script) { }
        public string Script { get { throw null; } set { } }
    }
    public partial class SrgsSubset : System.Speech.Recognition.SrgsGrammar.SrgsElement
    {
        public SrgsSubset(string text) { }
        public SrgsSubset(string text, System.Speech.Recognition.SubsetMatchingMode matchingMode) { }
        public System.Speech.Recognition.SubsetMatchingMode MatchingMode { get { throw null; } set { } }
        public string Text { get { throw null; } set { } }
    }
    public partial class SrgsText : System.Speech.Recognition.SrgsGrammar.SrgsElement
    {
        public SrgsText() { }
        public SrgsText(string text) { }
        public string Text { get { throw null; } set { } }
    }
    public partial class SrgsToken : System.Speech.Recognition.SrgsGrammar.SrgsElement
    {
        public SrgsToken(string text) { }
        public string Display { get { throw null; } set { } }
        public string Pronunciation { get { throw null; } set { } }
        public string Text { get { throw null; } set { } }
    }
}
namespace System.Speech.Synthesis
{
    public partial class BookmarkReachedEventArgs : System.Speech.Synthesis.PromptEventArgs
    {
        internal BookmarkReachedEventArgs() { }
        public System.TimeSpan AudioPosition { get { throw null; } }
        public string Bookmark { get { throw null; } }
    }
    public partial class FilePrompt : System.Speech.Synthesis.Prompt
    {
        public FilePrompt(string path, System.Speech.Synthesis.SynthesisMediaType media) : base (default(string)) { }
        public FilePrompt(System.Uri promptFile, System.Speech.Synthesis.SynthesisMediaType media) : base (default(string)) { }
    }
    public partial class InstalledVoice
    {
        internal InstalledVoice() { }
        public bool Enabled { get { throw null; } set { } }
        public System.Speech.Synthesis.VoiceInfo VoiceInfo { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class PhonemeReachedEventArgs : System.Speech.Synthesis.PromptEventArgs
    {
        internal PhonemeReachedEventArgs() { }
        public System.TimeSpan AudioPosition { get { throw null; } }
        public System.TimeSpan Duration { get { throw null; } }
        public System.Speech.Synthesis.SynthesizerEmphasis Emphasis { get { throw null; } }
        public string NextPhoneme { get { throw null; } }
        public string Phoneme { get { throw null; } }
    }
    public partial class Prompt
    {
        public Prompt(System.Speech.Synthesis.PromptBuilder promptBuilder) { }
        public Prompt(string textToSpeak) { }
        public Prompt(string textToSpeak, System.Speech.Synthesis.SynthesisTextFormat media) { }
        public bool IsCompleted { get { throw null; } }
    }
    public enum PromptBreak
    {
        None = 0,
        ExtraSmall = 1,
        Small = 2,
        Medium = 3,
        Large = 4,
        ExtraLarge = 5,
    }
    public partial class PromptBuilder
    {
        public PromptBuilder() { }
        public PromptBuilder(System.Globalization.CultureInfo culture) { }
        public System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        public bool IsEmpty { get { throw null; } }
        public void AppendAudio(string path) { }
        public void AppendAudio(System.Uri audioFile) { }
        public void AppendAudio(System.Uri audioFile, string alternateText) { }
        public void AppendBookmark(string bookmarkName) { }
        public void AppendBreak() { }
        public void AppendBreak(System.Speech.Synthesis.PromptBreak strength) { }
        public void AppendBreak(System.TimeSpan duration) { }
        public void AppendPromptBuilder(System.Speech.Synthesis.PromptBuilder promptBuilder) { }
        public void AppendSsml(string path) { }
        public void AppendSsml(System.Uri ssmlFile) { }
        public void AppendSsml(System.Xml.XmlReader ssmlFile) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public void AppendSsmlMarkup(string ssmlMarkup) { }
        public void AppendText(string textToSpeak) { }
        public void AppendText(string textToSpeak, System.Speech.Synthesis.PromptEmphasis emphasis) { }
        public void AppendText(string textToSpeak, System.Speech.Synthesis.PromptRate rate) { }
        public void AppendText(string textToSpeak, System.Speech.Synthesis.PromptVolume volume) { }
        public void AppendTextWithAlias(string textToSpeak, string substitute) { }
        public void AppendTextWithHint(string textToSpeak, System.Speech.Synthesis.SayAs sayAs) { }
        public void AppendTextWithHint(string textToSpeak, string sayAs) { }
        public void AppendTextWithPronunciation(string textToSpeak, string pronunciation) { }
        public void ClearContent() { }
        public void EndParagraph() { }
        public void EndSentence() { }
        public void EndStyle() { }
        public void EndVoice() { }
        public void StartParagraph() { }
        public void StartParagraph(System.Globalization.CultureInfo culture) { }
        public void StartSentence() { }
        public void StartSentence(System.Globalization.CultureInfo culture) { }
        public void StartStyle(System.Speech.Synthesis.PromptStyle style) { }
        public void StartVoice(System.Globalization.CultureInfo culture) { }
        public void StartVoice(System.Speech.Synthesis.VoiceGender gender) { }
        public void StartVoice(System.Speech.Synthesis.VoiceGender gender, System.Speech.Synthesis.VoiceAge age) { }
        public void StartVoice(System.Speech.Synthesis.VoiceGender gender, System.Speech.Synthesis.VoiceAge age, int voiceAlternate) { }
        public void StartVoice(System.Speech.Synthesis.VoiceInfo voice) { }
        public void StartVoice(string name) { }
        public string ToXml() { throw null; }
    }
    public enum PromptEmphasis
    {
        NotSet = 0,
        Strong = 1,
        Moderate = 2,
        None = 3,
        Reduced = 4,
    }
    public abstract partial class PromptEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal PromptEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public System.Speech.Synthesis.Prompt Prompt { get { throw null; } }
    }
    public enum PromptRate
    {
        NotSet = 0,
        ExtraFast = 1,
        Fast = 2,
        Medium = 3,
        Slow = 4,
        ExtraSlow = 5,
    }
    public partial class PromptStyle
    {
        public PromptStyle() { }
        public PromptStyle(System.Speech.Synthesis.PromptEmphasis emphasis) { }
        public PromptStyle(System.Speech.Synthesis.PromptRate rate) { }
        public PromptStyle(System.Speech.Synthesis.PromptVolume volume) { }
        public System.Speech.Synthesis.PromptEmphasis Emphasis { get { throw null; } set { } }
        public System.Speech.Synthesis.PromptRate Rate { get { throw null; } set { } }
        public System.Speech.Synthesis.PromptVolume Volume { get { throw null; } set { } }
    }
    public enum PromptVolume
    {
        NotSet = 0,
        Silent = 1,
        ExtraSoft = 2,
        Soft = 3,
        Medium = 4,
        Loud = 5,
        ExtraLoud = 6,
        Default = 7,
    }
    public enum SayAs
    {
        SpellOut = 0,
        NumberOrdinal = 1,
        NumberCardinal = 2,
        Date = 3,
        DayMonthYear = 4,
        MonthDayYear = 5,
        YearMonthDay = 6,
        YearMonth = 7,
        MonthYear = 8,
        MonthDay = 9,
        DayMonth = 10,
        Year = 11,
        Month = 12,
        Day = 13,
        Time = 14,
        Time24 = 15,
        Time12 = 16,
        Telephone = 17,
        Text = 18,
    }
    public partial class SpeakCompletedEventArgs : System.Speech.Synthesis.PromptEventArgs
    {
        internal SpeakCompletedEventArgs() { }
    }
    public partial class SpeakProgressEventArgs : System.Speech.Synthesis.PromptEventArgs
    {
        internal SpeakProgressEventArgs() { }
        public System.TimeSpan AudioPosition { get { throw null; } }
        public int CharacterCount { get { throw null; } }
        public int CharacterPosition { get { throw null; } }
        public string Text { get { throw null; } }
    }
    public partial class SpeakStartedEventArgs : System.Speech.Synthesis.PromptEventArgs
    {
        internal SpeakStartedEventArgs() { }
    }
    public sealed partial class SpeechSynthesizer : System.IDisposable
    {
        public SpeechSynthesizer() { }
        public int Rate { get { throw null; } set { } }
        public System.Speech.Synthesis.SynthesizerState State { get { throw null; } }
        public System.Speech.Synthesis.VoiceInfo Voice { get { throw null; } }
        public int Volume { get { throw null; } set { } }
        public event System.EventHandler<System.Speech.Synthesis.BookmarkReachedEventArgs> BookmarkReached { add { } remove { } }
        public event System.EventHandler<System.Speech.Synthesis.PhonemeReachedEventArgs> PhonemeReached { add { } remove { } }
        public event System.EventHandler<System.Speech.Synthesis.SpeakCompletedEventArgs> SpeakCompleted { add { } remove { } }
        public event System.EventHandler<System.Speech.Synthesis.SpeakProgressEventArgs> SpeakProgress { add { } remove { } }
        public event System.EventHandler<System.Speech.Synthesis.SpeakStartedEventArgs> SpeakStarted { add { } remove { } }
        public event System.EventHandler<System.Speech.Synthesis.StateChangedEventArgs> StateChanged { add { } remove { } }
        public event System.EventHandler<System.Speech.Synthesis.VisemeReachedEventArgs> VisemeReached { add { } remove { } }
        public event System.EventHandler<System.Speech.Synthesis.VoiceChangeEventArgs> VoiceChange { add { } remove { } }
        public void AddLexicon(System.Uri uri, string mediaType) { }
        public void Dispose() { }
        ~SpeechSynthesizer() { }
        public System.Speech.Synthesis.Prompt GetCurrentlySpokenPrompt() { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Synthesis.InstalledVoice> GetInstalledVoices() { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Synthesis.InstalledVoice> GetInstalledVoices(System.Globalization.CultureInfo culture) { throw null; }
        public void Pause() { }
        public void RemoveLexicon(System.Uri uri) { }
        public void Resume() { }
        public void SelectVoice(string name) { }
        public void SelectVoiceByHints(System.Speech.Synthesis.VoiceGender gender) { }
        public void SelectVoiceByHints(System.Speech.Synthesis.VoiceGender gender, System.Speech.Synthesis.VoiceAge age) { }
        public void SelectVoiceByHints(System.Speech.Synthesis.VoiceGender gender, System.Speech.Synthesis.VoiceAge age, int voiceAlternate) { }
        public void SelectVoiceByHints(System.Speech.Synthesis.VoiceGender gender, System.Speech.Synthesis.VoiceAge age, int voiceAlternate, System.Globalization.CultureInfo culture) { }
        public void SetOutputToAudioStream(System.IO.Stream audioDestination, System.Speech.AudioFormat.SpeechAudioFormatInfo formatInfo) { }
        public void SetOutputToDefaultAudioDevice() { }
        public void SetOutputToNull() { }
        public void SetOutputToWaveFile(string path) { }
        public void SetOutputToWaveFile(string path, System.Speech.AudioFormat.SpeechAudioFormatInfo formatInfo) { }
        public void SetOutputToWaveStream(System.IO.Stream audioDestination) { }
        public void Speak(System.Speech.Synthesis.Prompt prompt) { }
        public void Speak(System.Speech.Synthesis.PromptBuilder promptBuilder) { }
        public void Speak(string textToSpeak) { }
        public void SpeakAsync(System.Speech.Synthesis.Prompt prompt) { }
        public System.Speech.Synthesis.Prompt SpeakAsync(System.Speech.Synthesis.PromptBuilder promptBuilder) { throw null; }
        public System.Speech.Synthesis.Prompt SpeakAsync(string textToSpeak) { throw null; }
        public void SpeakAsyncCancel(System.Speech.Synthesis.Prompt prompt) { }
        public void SpeakAsyncCancelAll() { }
        public void SpeakSsml(string textToSpeak) { }
        public System.Speech.Synthesis.Prompt SpeakSsmlAsync(string textToSpeak) { throw null; }
    }
    public partial class StateChangedEventArgs : System.EventArgs
    {
        internal StateChangedEventArgs() { }
        public System.Speech.Synthesis.SynthesizerState PreviousState { get { throw null; } }
        public System.Speech.Synthesis.SynthesizerState State { get { throw null; } }
    }
    public enum SynthesisMediaType
    {
        Text = 0,
        Ssml = 1,
        WaveAudio = 2,
    }
    public enum SynthesisTextFormat
    {
        Text = 0,
        Ssml = 1,
    }
    [System.FlagsAttribute]
    public enum SynthesizerEmphasis
    {
        Stressed = 1,
        Emphasized = 2,
    }
    public enum SynthesizerState
    {
        Ready = 0,
        Speaking = 1,
        Paused = 2,
    }
    public partial class VisemeReachedEventArgs : System.Speech.Synthesis.PromptEventArgs
    {
        internal VisemeReachedEventArgs() { }
        public System.TimeSpan AudioPosition { get { throw null; } }
        public System.TimeSpan Duration { get { throw null; } }
        public System.Speech.Synthesis.SynthesizerEmphasis Emphasis { get { throw null; } }
        public int NextViseme { get { throw null; } }
        public int Viseme { get { throw null; } }
    }
    public enum VoiceAge
    {
        NotSet = 0,
        Child = 10,
        Teen = 15,
        Adult = 30,
        Senior = 65,
    }
    public partial class VoiceChangeEventArgs : System.Speech.Synthesis.PromptEventArgs
    {
        internal VoiceChangeEventArgs() { }
        public System.Speech.Synthesis.VoiceInfo Voice { get { throw null; } }
    }
    public enum VoiceGender
    {
        NotSet = 0,
        Male = 1,
        Female = 2,
        Neutral = 3,
    }
    public partial class VoiceInfo
    {
        internal VoiceInfo() { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Collections.Generic.IDictionary<string, string> AdditionalInfo { get { throw null; } }
        public System.Speech.Synthesis.VoiceAge Age { get { throw null; } }
        public System.Globalization.CultureInfo Culture { get { throw null; } }
        public string Description { get { throw null; } }
        public System.Speech.Synthesis.VoiceGender Gender { get { throw null; } }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.AudioFormat.SpeechAudioFormatInfo> SupportedAudioFormats { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
}
namespace System.Speech.Synthesis.TtsEngine
{
    [System.ComponentModel.ImmutableObjectAttribute(true)]
    public partial struct ContourPoint : System.IEquatable<System.Speech.Synthesis.TtsEngine.ContourPoint>
    {
        private int _dummyPrimitive;
        public ContourPoint(float start, float change, System.Speech.Synthesis.TtsEngine.ContourPointChangeType changeType) { throw null; }
        public float Change { get { throw null; } }
        public System.Speech.Synthesis.TtsEngine.ContourPointChangeType ChangeType { get { throw null; } }
        public float Start { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Speech.Synthesis.TtsEngine.ContourPoint other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Speech.Synthesis.TtsEngine.ContourPoint point1, System.Speech.Synthesis.TtsEngine.ContourPoint point2) { throw null; }
        public static bool operator !=(System.Speech.Synthesis.TtsEngine.ContourPoint point1, System.Speech.Synthesis.TtsEngine.ContourPoint point2) { throw null; }
    }
    public enum ContourPointChangeType
    {
        Hz = 0,
        Percentage = 1,
    }
    public enum EmphasisBreak
    {
        Default = -7,
        ExtraStrong = -6,
        Strong = -5,
        Medium = -4,
        Weak = -3,
        ExtraWeak = -2,
        None = -1,
    }
    public enum EmphasisWord
    {
        Default = 0,
        Strong = 1,
        Moderate = 2,
        None = 3,
        Reduced = 4,
    }
    public enum EventParameterType
    {
        Undefined = 0,
        Token = 1,
        Object = 2,
        Pointer = 3,
        String = 4,
    }
    [System.ComponentModel.ImmutableObjectAttribute(true)]
    public partial struct FragmentState : System.IEquatable<System.Speech.Synthesis.TtsEngine.FragmentState>
    {
        private object _dummy;
        private int _dummyPrimitive;
        public FragmentState(System.Speech.Synthesis.TtsEngine.TtsEngineAction action, int langId, int emphasis, int duration, System.Speech.Synthesis.TtsEngine.SayAs sayAs, System.Speech.Synthesis.TtsEngine.Prosody prosody, char[] phonemes) { throw null; }
        public System.Speech.Synthesis.TtsEngine.TtsEngineAction Action { get { throw null; } }
        public int Duration { get { throw null; } }
        public int Emphasis { get { throw null; } }
        public int LangId { get { throw null; } }
        public char[] Phoneme { get { throw null; } }
        public System.Speech.Synthesis.TtsEngine.Prosody Prosody { get { throw null; } }
        public System.Speech.Synthesis.TtsEngine.SayAs SayAs { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Speech.Synthesis.TtsEngine.FragmentState other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Speech.Synthesis.TtsEngine.FragmentState state1, System.Speech.Synthesis.TtsEngine.FragmentState state2) { throw null; }
        public static bool operator !=(System.Speech.Synthesis.TtsEngine.FragmentState state1, System.Speech.Synthesis.TtsEngine.FragmentState state2) { throw null; }
    }
    public partial interface ITtsEngineSite
    {
        int Actions { get; }
        int EventInterest { get; }
        int Rate { get; }
        int Volume { get; }
        void AddEvents(System.Speech.Synthesis.TtsEngine.SpeechEventInfo[] events, int count);
        void CompleteSkip(int skipped);
        System.Speech.Synthesis.TtsEngine.SkipInfo GetSkipInfo();
        System.IO.Stream LoadResource(System.Uri uri, string mediaType);
        int Write(System.IntPtr data, int count);
    }
    public partial class Prosody
    {
        public Prosody() { }
        public int Duration { get { throw null; } set { } }
        public System.Speech.Synthesis.TtsEngine.ProsodyNumber Pitch { get { throw null; } set { } }
        public System.Speech.Synthesis.TtsEngine.ProsodyNumber Range { get { throw null; } set { } }
        public System.Speech.Synthesis.TtsEngine.ProsodyNumber Rate { get { throw null; } set { } }
        public System.Speech.Synthesis.TtsEngine.ProsodyNumber Volume { get { throw null; } set { } }
        public System.Speech.Synthesis.TtsEngine.ContourPoint[] GetContourPoints() { throw null; }
        public void SetContourPoints(System.Speech.Synthesis.TtsEngine.ContourPoint[] points) { }
    }
    [System.ComponentModel.ImmutableObjectAttribute(true)]
    public partial struct ProsodyNumber : System.IEquatable<System.Speech.Synthesis.TtsEngine.ProsodyNumber>
    {
        private int _dummyPrimitive;
        public const int AbsoluteNumber = 2147483647;
        public ProsodyNumber(int ssmlAttributeId) { throw null; }
        public ProsodyNumber(float number) { throw null; }
        public bool IsNumberPercent { get { throw null; } }
        public float Number { get { throw null; } }
        public int SsmlAttributeId { get { throw null; } }
        public System.Speech.Synthesis.TtsEngine.ProsodyUnit Unit { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Speech.Synthesis.TtsEngine.ProsodyNumber other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Speech.Synthesis.TtsEngine.ProsodyNumber prosodyNumber1, System.Speech.Synthesis.TtsEngine.ProsodyNumber prosodyNumber2) { throw null; }
        public static bool operator !=(System.Speech.Synthesis.TtsEngine.ProsodyNumber prosodyNumber1, System.Speech.Synthesis.TtsEngine.ProsodyNumber prosodyNumber2) { throw null; }
    }
    public enum ProsodyPitch
    {
        Default = 0,
        ExtraLow = 1,
        Low = 2,
        Medium = 3,
        High = 4,
        ExtraHigh = 5,
    }
    public enum ProsodyRange
    {
        Default = 0,
        ExtraLow = 1,
        Low = 2,
        Medium = 3,
        High = 4,
        ExtraHigh = 5,
    }
    public enum ProsodyRate
    {
        Default = 0,
        ExtraSlow = 1,
        Slow = 2,
        Medium = 3,
        Fast = 4,
        ExtraFast = 5,
    }
    public enum ProsodyUnit
    {
        Default = 0,
        Hz = 1,
        Semitone = 2,
    }
    public enum ProsodyVolume
    {
        ExtraLoud = -7,
        Loud = -6,
        Medium = -5,
        Soft = -4,
        ExtraSoft = -3,
        Silent = -2,
        Default = -1,
    }
    public partial class SayAs
    {
        public SayAs() { }
        public string Detail { get { throw null; } set { } }
        public string Format { get { throw null; } set { } }
        public string InterpretAs { get { throw null; } set { } }
    }
    public partial class SkipInfo
    {
        public SkipInfo() { }
        public int Count { get { throw null; } set { } }
        public int Type { get { throw null; } set { } }
    }
    public enum SpeakOutputFormat
    {
        WaveFormat = 0,
        Text = 1,
    }
    [System.ComponentModel.ImmutableObjectAttribute(true)]
    public partial struct SpeechEventInfo : System.IEquatable<System.Speech.Synthesis.TtsEngine.SpeechEventInfo>
    {
        private int _dummyPrimitive;
        public SpeechEventInfo(short eventId, short parameterType, int param1, System.IntPtr param2) { throw null; }
        public short EventId { get { throw null; } }
        public int Param1 { get { throw null; } }
        public System.IntPtr Param2 { get { throw null; } }
        public short ParameterType { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Speech.Synthesis.TtsEngine.SpeechEventInfo other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Speech.Synthesis.TtsEngine.SpeechEventInfo event1, System.Speech.Synthesis.TtsEngine.SpeechEventInfo event2) { throw null; }
        public static bool operator !=(System.Speech.Synthesis.TtsEngine.SpeechEventInfo event1, System.Speech.Synthesis.TtsEngine.SpeechEventInfo event2) { throw null; }
    }
    public partial class TextFragment
    {
        public TextFragment() { }
        public System.Speech.Synthesis.TtsEngine.FragmentState State { get { throw null; } set { } }
        public int TextLength { get { throw null; } set { } }
        public int TextOffset { get { throw null; } set { } }
        public string TextToSpeak { get { throw null; } set { } }
    }
    public enum TtsEngineAction
    {
        Speak = 0,
        Silence = 1,
        Pronounce = 2,
        Bookmark = 3,
        SpellOut = 4,
        StartSentence = 5,
        StartParagraph = 6,
        ParseUnknownTag = 7,
    }
    public abstract partial class TtsEngineSsml
    {
        protected TtsEngineSsml(string registryKey) { }
        public abstract void AddLexicon(System.Uri uri, string mediaType, System.Speech.Synthesis.TtsEngine.ITtsEngineSite site);
        public abstract System.IntPtr GetOutputFormat(System.Speech.Synthesis.TtsEngine.SpeakOutputFormat speakOutputFormat, System.IntPtr targetWaveFormat);
        public abstract void RemoveLexicon(System.Uri uri, System.Speech.Synthesis.TtsEngine.ITtsEngineSite site);
        public abstract void Speak(System.Speech.Synthesis.TtsEngine.TextFragment[] fragment, System.IntPtr waveHeader, System.Speech.Synthesis.TtsEngine.ITtsEngineSite site);
    }
    public enum TtsEventId
    {
        StartInputStream = 1,
        EndInputStream = 2,
        VoiceChange = 3,
        Bookmark = 4,
        WordBoundary = 5,
        Phoneme = 6,
        SentenceBoundary = 7,
        Viseme = 8,
        AudioLevel = 9,
    }
}
