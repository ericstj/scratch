// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// ------------------------------------------------------------------------------
// Changes to this file must follow the https://aka.ms/api-review process.
// ------------------------------------------------------------------------------

namespace System.Diagnostics
{
    public partial class Activity : System.IDisposable
    {
        public Activity(string operationName) { }
        public System.Diagnostics.ActivityTraceFlags ActivityTraceFlags { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string?>> Baggage { get { throw null; } }
        public System.Diagnostics.ActivityContext Context { get { throw null; } }
        public static System.Diagnostics.Activity? Current { get { throw null; } set { } }
        public static System.Diagnostics.ActivityIdFormat DefaultIdFormat { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public System.TimeSpan Duration { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Diagnostics.ActivityEvent> Events { get { throw null; } }
        public static bool ForceDefaultIdFormat { get { throw null; } set { } }
        public bool HasRemoteParent { get { throw null; } }
        public string? Id { get { throw null; } }
        public System.Diagnostics.ActivityIdFormat IdFormat { get { throw null; } }
        public bool IsAllDataRequested { get { throw null; } set { } }
        public bool IsStopped { get { throw null; } }
        public System.Diagnostics.ActivityKind Kind { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Diagnostics.ActivityLink> Links { get { throw null; } }
        public string OperationName { get { throw null; } }
        public System.Diagnostics.Activity? Parent { get { throw null; } }
        public string? ParentId { get { throw null; } }
        public System.Diagnostics.ActivitySpanId ParentSpanId { get { throw null; } }
        public bool Recorded { get { throw null; } }
        public string? RootId { get { throw null; } }
        public System.Diagnostics.ActivitySource Source { get { throw null; } }
        public System.Diagnostics.ActivitySpanId SpanId { get { throw null; } }
        public System.DateTime StartTimeUtc { get { throw null; } }
        public System.Diagnostics.ActivityStatusCode Status { get { throw null; } }
        public string? StatusDescription { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object?>> TagObjects { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string?>> Tags { get { throw null; } }
        public System.Diagnostics.ActivityTraceId TraceId { get { throw null; } }
        public static System.Func<System.Diagnostics.ActivityTraceId>? TraceIdGenerator { get { throw null; } set { } }
        public string? TraceStateString { get { throw null; } set { } }
        public static event System.EventHandler<System.Diagnostics.ActivityChangedEventArgs>? CurrentChanged { add { } remove { } }
        public System.Diagnostics.Activity AddBaggage(string key, string? value) { throw null; }
        public System.Diagnostics.Activity AddEvent(System.Diagnostics.ActivityEvent e) { throw null; }
        public System.Diagnostics.Activity AddTag(string key, object? value) { throw null; }
        public System.Diagnostics.Activity AddTag(string key, string? value) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public System.Diagnostics.Activity.Enumerator<System.Diagnostics.ActivityEvent> EnumerateEvents() { throw null; }
        public System.Diagnostics.Activity.Enumerator<System.Diagnostics.ActivityLink> EnumerateLinks() { throw null; }
        public System.Diagnostics.Activity.Enumerator<System.Collections.Generic.KeyValuePair<string, object?>> EnumerateTagObjects() { throw null; }
        public string? GetBaggageItem(string key) { throw null; }
        public object? GetCustomProperty(string propertyName) { throw null; }
        public object? GetTagItem(string key) { throw null; }
        public System.Diagnostics.Activity SetBaggage(string key, string? value) { throw null; }
        public void SetCustomProperty(string propertyName, object? propertyValue) { }
        public System.Diagnostics.Activity SetEndTime(System.DateTime endTimeUtc) { throw null; }
        public System.Diagnostics.Activity SetIdFormat(System.Diagnostics.ActivityIdFormat format) { throw null; }
        public System.Diagnostics.Activity SetParentId(System.Diagnostics.ActivityTraceId traceId, System.Diagnostics.ActivitySpanId spanId, System.Diagnostics.ActivityTraceFlags activityTraceFlags = System.Diagnostics.ActivityTraceFlags.None) { throw null; }
        public System.Diagnostics.Activity SetParentId(string parentId) { throw null; }
        public System.Diagnostics.Activity SetStartTime(System.DateTime startTimeUtc) { throw null; }
        public System.Diagnostics.Activity SetStatus(System.Diagnostics.ActivityStatusCode code, string? description = null) { throw null; }
        public System.Diagnostics.Activity SetTag(string key, object? value) { throw null; }
        public System.Diagnostics.Activity Start() { throw null; }
        public void Stop() { }
        public partial struct Enumerator<T>
        {
            private object _dummy;
            private int _dummyPrimitive;
            public readonly ref T Current { get { throw null; } }
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            public readonly System.Diagnostics.Activity.Enumerator<T> GetEnumerator() { throw null; }
            public bool MoveNext() { throw null; }
        }
    }
    public readonly partial struct ActivityChangedEventArgs
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public System.Diagnostics.Activity? Current { get { throw null; } set { } }
        public System.Diagnostics.Activity? Previous { get { throw null; } set { } }
    }
    public readonly partial struct ActivityContext : System.IEquatable<System.Diagnostics.ActivityContext>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ActivityContext(System.Diagnostics.ActivityTraceId traceId, System.Diagnostics.ActivitySpanId spanId, System.Diagnostics.ActivityTraceFlags traceFlags, string? traceState = null, bool isRemote = false) { throw null; }
        public bool IsRemote { get { throw null; } }
        public System.Diagnostics.ActivitySpanId SpanId { get { throw null; } }
        public System.Diagnostics.ActivityTraceFlags TraceFlags { get { throw null; } }
        public System.Diagnostics.ActivityTraceId TraceId { get { throw null; } }
        public string? TraceState { get { throw null; } }
        public bool Equals(System.Diagnostics.ActivityContext value) { throw null; }
        public override bool Equals([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] object? obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Diagnostics.ActivityContext left, System.Diagnostics.ActivityContext right) { throw null; }
        public static bool operator !=(System.Diagnostics.ActivityContext left, System.Diagnostics.ActivityContext right) { throw null; }
        public static System.Diagnostics.ActivityContext Parse(string traceParent, string? traceState) { throw null; }
        public static bool TryParse(string? traceParent, string? traceState, bool isRemote, out System.Diagnostics.ActivityContext context) { throw null; }
        public static bool TryParse(string? traceParent, string? traceState, out System.Diagnostics.ActivityContext context) { throw null; }
    }
    public readonly partial struct ActivityCreationOptions<T>
    {
        private readonly T _Parent_k__BackingField;
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public System.Diagnostics.ActivityKind Kind { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Diagnostics.ActivityLink>? Links { get { throw null; } }
        public string Name { get { throw null; } }
        public T Parent { get { throw null; } }
        public System.Diagnostics.ActivityTagsCollection SamplingTags { get { throw null; } }
        public System.Diagnostics.ActivitySource Source { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object?>>? Tags { get { throw null; } }
        public System.Diagnostics.ActivityTraceId TraceId { get { throw null; } }
        public string? TraceState { get { throw null; } set { } }
    }
    public readonly partial struct ActivityEvent
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ActivityEvent(string name) { throw null; }
        public ActivityEvent(string name, System.DateTimeOffset timestamp = default(System.DateTimeOffset), System.Diagnostics.ActivityTagsCollection? tags = null) { throw null; }
        public string Name { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object?>> Tags { get { throw null; } }
        public System.DateTimeOffset Timestamp { get { throw null; } }
    }
    public enum ActivityIdFormat
    {
        Unknown = 0,
        Hierarchical = 1,
        W3C = 2,
    }
    public enum ActivityKind
    {
        Internal = 0,
        Server = 1,
        Client = 2,
        Producer = 3,
        Consumer = 4,
    }
    public readonly partial struct ActivityLink : System.IEquatable<System.Diagnostics.ActivityLink>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ActivityLink(System.Diagnostics.ActivityContext context, System.Diagnostics.ActivityTagsCollection? tags = null) { throw null; }
        public System.Diagnostics.ActivityContext Context { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object?>>? Tags { get { throw null; } }
        public bool Equals(System.Diagnostics.ActivityLink value) { throw null; }
        public override bool Equals([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] object? obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Diagnostics.ActivityLink left, System.Diagnostics.ActivityLink right) { throw null; }
        public static bool operator !=(System.Diagnostics.ActivityLink left, System.Diagnostics.ActivityLink right) { throw null; }
    }
    public sealed partial class ActivityListener : System.IDisposable
    {
        public ActivityListener() { }
        public System.Action<System.Diagnostics.Activity>? ActivityStarted { get { throw null; } set { } }
        public System.Action<System.Diagnostics.Activity>? ActivityStopped { get { throw null; } set { } }
        public System.Diagnostics.SampleActivity<System.Diagnostics.ActivityContext>? Sample { get { throw null; } set { } }
        public System.Diagnostics.SampleActivity<string>? SampleUsingParentId { get { throw null; } set { } }
        public System.Func<System.Diagnostics.ActivitySource, bool>? ShouldListenTo { get { throw null; } set { } }
        public void Dispose() { }
    }
    public enum ActivitySamplingResult
    {
        None = 0,
        PropagationData = 1,
        AllData = 2,
        AllDataAndRecorded = 3,
    }
    public sealed partial class ActivitySource : System.IDisposable
    {
        public ActivitySource(string name, string? version = "") { }
        public string Name { get { throw null; } }
        public string? Version { get { throw null; } }
        public static void AddActivityListener(System.Diagnostics.ActivityListener listener) { }
        public System.Diagnostics.Activity? CreateActivity(string name, System.Diagnostics.ActivityKind kind) { throw null; }
        public System.Diagnostics.Activity? CreateActivity(string name, System.Diagnostics.ActivityKind kind, System.Diagnostics.ActivityContext parentContext, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object?>>? tags = null, System.Collections.Generic.IEnumerable<System.Diagnostics.ActivityLink>? links = null, System.Diagnostics.ActivityIdFormat idFormat = System.Diagnostics.ActivityIdFormat.Unknown) { throw null; }
        public System.Diagnostics.Activity? CreateActivity(string name, System.Diagnostics.ActivityKind kind, string parentId, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object?>>? tags = null, System.Collections.Generic.IEnumerable<System.Diagnostics.ActivityLink>? links = null, System.Diagnostics.ActivityIdFormat idFormat = System.Diagnostics.ActivityIdFormat.Unknown) { throw null; }
        public void Dispose() { }
        public bool HasListeners() { throw null; }
        public System.Diagnostics.Activity? StartActivity(System.Diagnostics.ActivityKind kind, System.Diagnostics.ActivityContext parentContext = default(System.Diagnostics.ActivityContext), System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object?>>? tags = null, System.Collections.Generic.IEnumerable<System.Diagnostics.ActivityLink>? links = null, System.DateTimeOffset startTime = default(System.DateTimeOffset), [System.Runtime.CompilerServices.CallerMemberNameAttribute] string name = "") { throw null; }
        public System.Diagnostics.Activity? StartActivity([System.Runtime.CompilerServices.CallerMemberNameAttribute] string name = "", System.Diagnostics.ActivityKind kind = System.Diagnostics.ActivityKind.Internal) { throw null; }
        public System.Diagnostics.Activity? StartActivity(string name, System.Diagnostics.ActivityKind kind, System.Diagnostics.ActivityContext parentContext, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object?>>? tags = null, System.Collections.Generic.IEnumerable<System.Diagnostics.ActivityLink>? links = null, System.DateTimeOffset startTime = default(System.DateTimeOffset)) { throw null; }
        public System.Diagnostics.Activity? StartActivity(string name, System.Diagnostics.ActivityKind kind, string parentId, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object?>>? tags = null, System.Collections.Generic.IEnumerable<System.Diagnostics.ActivityLink>? links = null, System.DateTimeOffset startTime = default(System.DateTimeOffset)) { throw null; }
    }
    public readonly partial struct ActivitySpanId : System.IEquatable<System.Diagnostics.ActivitySpanId>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public void CopyTo(System.Span<byte> destination) { }
        public static System.Diagnostics.ActivitySpanId CreateFromBytes(System.ReadOnlySpan<byte> idData) { throw null; }
        public static System.Diagnostics.ActivitySpanId CreateFromString(System.ReadOnlySpan<char> idData) { throw null; }
        public static System.Diagnostics.ActivitySpanId CreateFromUtf8String(System.ReadOnlySpan<byte> idData) { throw null; }
        public static System.Diagnostics.ActivitySpanId CreateRandom() { throw null; }
        public bool Equals(System.Diagnostics.ActivitySpanId spanId) { throw null; }
        public override bool Equals([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] object? obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Diagnostics.ActivitySpanId spanId1, System.Diagnostics.ActivitySpanId spandId2) { throw null; }
        public static bool operator !=(System.Diagnostics.ActivitySpanId spanId1, System.Diagnostics.ActivitySpanId spandId2) { throw null; }
        public string ToHexString() { throw null; }
        public override string ToString() { throw null; }
    }
    public enum ActivityStatusCode
    {
        Unset = 0,
        Ok = 1,
        Error = 2,
    }
    public partial class ActivityTagsCollection : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object?>>, System.Collections.Generic.IDictionary<string, object?>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object?>>, System.Collections.IEnumerable
    {
        public ActivityTagsCollection() { }
        public ActivityTagsCollection(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object?>> list) { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public object? this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        public System.Collections.Generic.ICollection<object?> Values { get { throw null; } }
        public void Add(System.Collections.Generic.KeyValuePair<string, object?> item) { }
        public void Add(string key, object? value) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<string, object?> item) { throw null; }
        public bool ContainsKey(string key) { throw null; }
        public void CopyTo(System.Collections.Generic.KeyValuePair<string, object>[] array, int arrayIndex) { }
        public System.Diagnostics.ActivityTagsCollection.Enumerator GetEnumerator() { throw null; }
        public bool Remove(System.Collections.Generic.KeyValuePair<string, object?> item) { throw null; }
        public bool Remove(string key) { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object?>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out object? value) { throw null; }
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object?>>, System.Collections.IEnumerator, System.IDisposable
        {
            private object _dummy;
            private int _dummyPrimitive;
            public System.Collections.Generic.KeyValuePair<string, object?> Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            void System.Collections.IEnumerator.Reset() { }
        }
    }
    [System.FlagsAttribute]
    public enum ActivityTraceFlags
    {
        None = 0,
        Recorded = 1,
    }
    public readonly partial struct ActivityTraceId : System.IEquatable<System.Diagnostics.ActivityTraceId>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public void CopyTo(System.Span<byte> destination) { }
        public static System.Diagnostics.ActivityTraceId CreateFromBytes(System.ReadOnlySpan<byte> idData) { throw null; }
        public static System.Diagnostics.ActivityTraceId CreateFromString(System.ReadOnlySpan<char> idData) { throw null; }
        public static System.Diagnostics.ActivityTraceId CreateFromUtf8String(System.ReadOnlySpan<byte> idData) { throw null; }
        public static System.Diagnostics.ActivityTraceId CreateRandom() { throw null; }
        public bool Equals(System.Diagnostics.ActivityTraceId traceId) { throw null; }
        public override bool Equals([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] object? obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Diagnostics.ActivityTraceId traceId1, System.Diagnostics.ActivityTraceId traceId2) { throw null; }
        public static bool operator !=(System.Diagnostics.ActivityTraceId traceId1, System.Diagnostics.ActivityTraceId traceId2) { throw null; }
        public string ToHexString() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DiagnosticListener : System.Diagnostics.DiagnosticSource, System.IDisposable, System.IObservable<System.Collections.Generic.KeyValuePair<string, object?>>
    {
        public DiagnosticListener(string name) { }
        public static System.IObservable<System.Diagnostics.DiagnosticListener> AllListeners { get { throw null; } }
        public string Name { get { throw null; } }
        public virtual void Dispose() { }
        public bool IsEnabled() { throw null; }
        public override bool IsEnabled(string name) { throw null; }
        public override bool IsEnabled(string name, object? arg1, object? arg2 = null) { throw null; }
        public override void OnActivityExport(System.Diagnostics.Activity activity, object? payload) { }
        public override void OnActivityImport(System.Diagnostics.Activity activity, object? payload) { }
        public virtual System.IDisposable Subscribe(System.IObserver<System.Collections.Generic.KeyValuePair<string, object?>> observer) { throw null; }
        public virtual System.IDisposable Subscribe(System.IObserver<System.Collections.Generic.KeyValuePair<string, object?>> observer, System.Func<string, object?, object?, bool>? isEnabled) { throw null; }
        public virtual System.IDisposable Subscribe(System.IObserver<System.Collections.Generic.KeyValuePair<string, object?>> observer, System.Func<string, object?, object?, bool>? isEnabled, System.Action<System.Diagnostics.Activity, object?>? onActivityImport = null, System.Action<System.Diagnostics.Activity, object?>? onActivityExport = null) { throw null; }
        public virtual System.IDisposable Subscribe(System.IObserver<System.Collections.Generic.KeyValuePair<string, object?>> observer, System.Predicate<string>? isEnabled) { throw null; }
        public override string ToString() { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("The type of object being written to DiagnosticSource cannot be discovered statically.")]
        public override void Write(string name, object? value) { }
    }
    public abstract partial class DiagnosticSource
    {
        protected DiagnosticSource() { }
        public abstract bool IsEnabled(string name);
        public virtual bool IsEnabled(string name, object? arg1, object? arg2 = null) { throw null; }
        public virtual void OnActivityExport(System.Diagnostics.Activity activity, object? payload) { }
        public virtual void OnActivityImport(System.Diagnostics.Activity activity, object? payload) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("The type of object being written to DiagnosticSource cannot be discovered statically.")]
        public System.Diagnostics.Activity StartActivity(System.Diagnostics.Activity activity, object? args) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("The type of object being written to DiagnosticSource cannot be discovered statically.")]
        public void StopActivity(System.Diagnostics.Activity activity, object? args) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("The type of object being written to DiagnosticSource cannot be discovered statically.")]
        public abstract void Write(string name, object? value);
    }
    public abstract partial class DistributedContextPropagator
    {
        protected DistributedContextPropagator() { }
        public static System.Diagnostics.DistributedContextPropagator Current { get { throw null; } set { } }
        public abstract System.Collections.Generic.IReadOnlyCollection<string> Fields { get; }
        public static System.Diagnostics.DistributedContextPropagator CreateDefaultPropagator() { throw null; }
        public static System.Diagnostics.DistributedContextPropagator CreateNoOutputPropagator() { throw null; }
        public static System.Diagnostics.DistributedContextPropagator CreatePassThroughPropagator() { throw null; }
        public abstract System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string?>>? ExtractBaggage(object? carrier, System.Diagnostics.DistributedContextPropagator.PropagatorGetterCallback? getter);
        public abstract void ExtractTraceIdAndState(object? carrier, System.Diagnostics.DistributedContextPropagator.PropagatorGetterCallback? getter, out string? traceId, out string? traceState);
        public abstract void Inject(System.Diagnostics.Activity? activity, object? carrier, System.Diagnostics.DistributedContextPropagator.PropagatorSetterCallback? setter);
        public delegate void PropagatorGetterCallback(object? carrier, string fieldName, out string? fieldValue, out System.Collections.Generic.IEnumerable<string>? fieldValues);
        public delegate void PropagatorSetterCallback(object? carrier, string fieldName, string fieldValue);
    }
    public delegate System.Diagnostics.ActivitySamplingResult SampleActivity<T>(ref System.Diagnostics.ActivityCreationOptions<T> options);
    public partial struct TagList : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object?>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object?>>, System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object?>>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<string, object?>>, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.KeyValuePair<string, object?>>, System.Collections.IEnumerable
    {
        private object _dummy;
        private int _dummyPrimitive;
        public TagList(System.ReadOnlySpan<System.Collections.Generic.KeyValuePair<string, object?>> tagList) { throw null; }
        public readonly int Count { get { throw null; } }
        public readonly bool IsReadOnly { get { throw null; } }
        public System.Collections.Generic.KeyValuePair<string, object?> this[int index] { readonly get { throw null; } set { } }
        public void Add(System.Collections.Generic.KeyValuePair<string, object?> tag) { }
        public void Add(string key, object? value) { }
        public void Clear() { }
        public readonly bool Contains(System.Collections.Generic.KeyValuePair<string, object?> item) { throw null; }
        public readonly void CopyTo(System.Collections.Generic.KeyValuePair<string, object>[] array, int arrayIndex) { }
        public readonly void CopyTo(System.Span<System.Collections.Generic.KeyValuePair<string, object?>> tags) { }
        public readonly System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object?>> GetEnumerator() { throw null; }
        public readonly int IndexOf(System.Collections.Generic.KeyValuePair<string, object?> item) { throw null; }
        public void Insert(int index, System.Collections.Generic.KeyValuePair<string, object?> item) { }
        public bool Remove(System.Collections.Generic.KeyValuePair<string, object?> item) { throw null; }
        public void RemoveAt(int index) { }
        readonly System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object?>>, System.Collections.IEnumerator, System.IDisposable
        {
            private object _dummy;
            private int _dummyPrimitive;
            public System.Collections.Generic.KeyValuePair<string, object?> Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            public void Reset() { }
        }
    }
}
namespace System.Diagnostics.Metrics
{
    public sealed partial class Counter<T> : System.Diagnostics.Metrics.Instrument<T> where T : struct
    {
        internal Counter() : base (default(System.Diagnostics.Metrics.Meter), default(string), default(string), default(string)) { }
        public void Add(T delta) { }
        public void Add(T delta, System.Collections.Generic.KeyValuePair<string, object?> tag) { }
        public void Add(T delta, System.Collections.Generic.KeyValuePair<string, object?> tag1, System.Collections.Generic.KeyValuePair<string, object?> tag2) { }
        public void Add(T delta, System.Collections.Generic.KeyValuePair<string, object?> tag1, System.Collections.Generic.KeyValuePair<string, object?> tag2, System.Collections.Generic.KeyValuePair<string, object?> tag3) { }
        public void Add(T delta, params System.Collections.Generic.KeyValuePair<string, object>[] tags) { }
        public void Add(T delta, in System.Diagnostics.TagList tagList) { }
        public void Add(T delta, System.ReadOnlySpan<System.Collections.Generic.KeyValuePair<string, object?>> tags) { }
    }
    public sealed partial class Histogram<T> : System.Diagnostics.Metrics.Instrument<T> where T : struct
    {
        internal Histogram() : base (default(System.Diagnostics.Metrics.Meter), default(string), default(string), default(string)) { }
        public void Record(T value) { }
        public void Record(T value, System.Collections.Generic.KeyValuePair<string, object?> tag) { }
        public void Record(T value, System.Collections.Generic.KeyValuePair<string, object?> tag1, System.Collections.Generic.KeyValuePair<string, object?> tag2) { }
        public void Record(T value, System.Collections.Generic.KeyValuePair<string, object?> tag1, System.Collections.Generic.KeyValuePair<string, object?> tag2, System.Collections.Generic.KeyValuePair<string, object?> tag3) { }
        public void Record(T value, params System.Collections.Generic.KeyValuePair<string, object>[] tags) { }
        public void Record(T value, in System.Diagnostics.TagList tagList) { }
        public void Record(T value, System.ReadOnlySpan<System.Collections.Generic.KeyValuePair<string, object?>> tags) { }
    }
    public abstract partial class Instrument
    {
        protected Instrument(System.Diagnostics.Metrics.Meter meter, string name, string? unit, string? description) { }
        public string? Description { get { throw null; } }
        public bool Enabled { get { throw null; } }
        public virtual bool IsObservable { get { throw null; } }
        public System.Diagnostics.Metrics.Meter Meter { get { throw null; } }
        public string Name { get { throw null; } }
        public string? Unit { get { throw null; } }
        protected void Publish() { }
    }
    public abstract partial class Instrument<T> : System.Diagnostics.Metrics.Instrument where T : struct
    {
        protected Instrument(System.Diagnostics.Metrics.Meter meter, string name, string? unit, string? description) : base (default(System.Diagnostics.Metrics.Meter), default(string), default(string), default(string)) { }
        protected void RecordMeasurement(T measurement) { }
        protected void RecordMeasurement(T measurement, System.Collections.Generic.KeyValuePair<string, object?> tag) { }
        protected void RecordMeasurement(T measurement, System.Collections.Generic.KeyValuePair<string, object?> tag1, System.Collections.Generic.KeyValuePair<string, object?> tag2) { }
        protected void RecordMeasurement(T measurement, System.Collections.Generic.KeyValuePair<string, object?> tag1, System.Collections.Generic.KeyValuePair<string, object?> tag2, System.Collections.Generic.KeyValuePair<string, object?> tag3) { }
        protected void RecordMeasurement(T measurement, in System.Diagnostics.TagList tagList) { }
        protected void RecordMeasurement(T measurement, System.ReadOnlySpan<System.Collections.Generic.KeyValuePair<string, object?>> tags) { }
    }
    public delegate void MeasurementCallback<T>(System.Diagnostics.Metrics.Instrument instrument, T measurement, System.ReadOnlySpan<System.Collections.Generic.KeyValuePair<string, object?>> tags, object? state) where T : struct;
    public readonly partial struct Measurement<T> where T : struct
    {
        private readonly T _Value_k__BackingField;
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Measurement(T value) { throw null; }
        public Measurement(T value, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object?>>? tags) { throw null; }
        public Measurement(T value, params System.Collections.Generic.KeyValuePair<string, object>[]? tags) { throw null; }
        public Measurement(T value, System.ReadOnlySpan<System.Collections.Generic.KeyValuePair<string, object?>> tags) { throw null; }
        public System.ReadOnlySpan<System.Collections.Generic.KeyValuePair<string, object?>> Tags { get { throw null; } }
        public T Value { get { throw null; } }
    }
    public partial class Meter : System.IDisposable
    {
        public Meter(string name) { }
        public Meter(string name, string? version) { }
        public string Name { get { throw null; } }
        public string? Version { get { throw null; } }
        public System.Diagnostics.Metrics.Counter<T> CreateCounter<T>(string name, string? unit = null, string? description = null) where T : struct { throw null; }
        public System.Diagnostics.Metrics.Histogram<T> CreateHistogram<T>(string name, string? unit = null, string? description = null) where T : struct { throw null; }
        public System.Diagnostics.Metrics.ObservableCounter<T> CreateObservableCounter<T>(string name, System.Func<System.Collections.Generic.IEnumerable<System.Diagnostics.Metrics.Measurement<T>>> observeValues, string? unit = null, string? description = null) where T : struct { throw null; }
        public System.Diagnostics.Metrics.ObservableCounter<T> CreateObservableCounter<T>(string name, System.Func<System.Diagnostics.Metrics.Measurement<T>> observeValue, string? unit = null, string? description = null) where T : struct { throw null; }
        public System.Diagnostics.Metrics.ObservableCounter<T> CreateObservableCounter<T>(string name, System.Func<T> observeValue, string? unit = null, string? description = null) where T : struct { throw null; }
        public System.Diagnostics.Metrics.ObservableGauge<T> CreateObservableGauge<T>(string name, System.Func<System.Collections.Generic.IEnumerable<System.Diagnostics.Metrics.Measurement<T>>> observeValues, string? unit = null, string? description = null) where T : struct { throw null; }
        public System.Diagnostics.Metrics.ObservableGauge<T> CreateObservableGauge<T>(string name, System.Func<System.Diagnostics.Metrics.Measurement<T>> observeValue, string? unit = null, string? description = null) where T : struct { throw null; }
        public System.Diagnostics.Metrics.ObservableGauge<T> CreateObservableGauge<T>(string name, System.Func<T> observeValue, string? unit = null, string? description = null) where T : struct { throw null; }
        public System.Diagnostics.Metrics.ObservableUpDownCounter<T> CreateObservableUpDownCounter<T>(string name, System.Func<System.Collections.Generic.IEnumerable<System.Diagnostics.Metrics.Measurement<T>>> observeValues, string? unit = null, string? description = null) where T : struct { throw null; }
        public System.Diagnostics.Metrics.ObservableUpDownCounter<T> CreateObservableUpDownCounter<T>(string name, System.Func<System.Diagnostics.Metrics.Measurement<T>> observeValue, string? unit = null, string? description = null) where T : struct { throw null; }
        public System.Diagnostics.Metrics.ObservableUpDownCounter<T> CreateObservableUpDownCounter<T>(string name, System.Func<T> observeValue, string? unit = null, string? description = null) where T : struct { throw null; }
        public System.Diagnostics.Metrics.UpDownCounter<T> CreateUpDownCounter<T>(string name, string? unit = null, string? description = null) where T : struct { throw null; }
        public void Dispose() { }
    }
    public sealed partial class MeterListener : System.IDisposable
    {
        public MeterListener() { }
        public System.Action<System.Diagnostics.Metrics.Instrument, System.Diagnostics.Metrics.MeterListener>? InstrumentPublished { get { throw null; } set { } }
        public System.Action<System.Diagnostics.Metrics.Instrument, object?>? MeasurementsCompleted { get { throw null; } set { } }
        public object? DisableMeasurementEvents(System.Diagnostics.Metrics.Instrument instrument) { throw null; }
        public void Dispose() { }
        public void EnableMeasurementEvents(System.Diagnostics.Metrics.Instrument instrument, object? state = null) { }
        public void RecordObservableInstruments() { }
        public void SetMeasurementEventCallback<T>(System.Diagnostics.Metrics.MeasurementCallback<T>? measurementCallback) where T : struct { }
        public void Start() { }
    }
    public sealed partial class ObservableCounter<T> : System.Diagnostics.Metrics.ObservableInstrument<T> where T : struct
    {
        internal ObservableCounter() : base (default(System.Diagnostics.Metrics.Meter), default(string), default(string), default(string)) { }
        protected override System.Collections.Generic.IEnumerable<System.Diagnostics.Metrics.Measurement<T>> Observe() { throw null; }
    }
    public sealed partial class ObservableGauge<T> : System.Diagnostics.Metrics.ObservableInstrument<T> where T : struct
    {
        internal ObservableGauge() : base (default(System.Diagnostics.Metrics.Meter), default(string), default(string), default(string)) { }
        protected override System.Collections.Generic.IEnumerable<System.Diagnostics.Metrics.Measurement<T>> Observe() { throw null; }
    }
    public abstract partial class ObservableInstrument<T> : System.Diagnostics.Metrics.Instrument where T : struct
    {
        protected ObservableInstrument(System.Diagnostics.Metrics.Meter meter, string name, string? unit, string? description) : base (default(System.Diagnostics.Metrics.Meter), default(string), default(string), default(string)) { }
        public override bool IsObservable { get { throw null; } }
        protected abstract System.Collections.Generic.IEnumerable<System.Diagnostics.Metrics.Measurement<T>> Observe();
    }
    public sealed partial class ObservableUpDownCounter<T> : System.Diagnostics.Metrics.ObservableInstrument<T> where T : struct
    {
        internal ObservableUpDownCounter() : base (default(System.Diagnostics.Metrics.Meter), default(string), default(string), default(string)) { }
        protected override System.Collections.Generic.IEnumerable<System.Diagnostics.Metrics.Measurement<T>> Observe() { throw null; }
    }
    public sealed partial class UpDownCounter<T> : System.Diagnostics.Metrics.Instrument<T> where T : struct
    {
        internal UpDownCounter() : base (default(System.Diagnostics.Metrics.Meter), default(string), default(string), default(string)) { }
        public void Add(T delta) { }
        public void Add(T delta, System.Collections.Generic.KeyValuePair<string, object?> tag) { }
        public void Add(T delta, System.Collections.Generic.KeyValuePair<string, object?> tag1, System.Collections.Generic.KeyValuePair<string, object?> tag2) { }
        public void Add(T delta, System.Collections.Generic.KeyValuePair<string, object?> tag1, System.Collections.Generic.KeyValuePair<string, object?> tag2, System.Collections.Generic.KeyValuePair<string, object?> tag3) { }
        public void Add(T delta, params System.Collections.Generic.KeyValuePair<string, object>[] tags) { }
        public void Add(T delta, in System.Diagnostics.TagList tagList) { }
        public void Add(T delta, System.ReadOnlySpan<System.Collections.Generic.KeyValuePair<string, object?>> tags) { }
    }
}
