// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// ------------------------------------------------------------------------------
// Changes to this file must follow the https://aka.ms/api-review process.
// ------------------------------------------------------------------------------

namespace System.Threading.Channels
{
    public enum BoundedChannelFullMode
    {
        Wait = 0,
        DropNewest = 1,
        DropOldest = 2,
        DropWrite = 3,
    }
    public sealed partial class BoundedChannelOptions : System.Threading.Channels.ChannelOptions
    {
        public BoundedChannelOptions(int capacity) { }
        public int Capacity { get { throw null; } set { } }
        public System.Threading.Channels.BoundedChannelFullMode FullMode { get { throw null; } set { } }
    }
    public static partial class Channel
    {
        public static System.Threading.Channels.Channel<T> CreateBounded<T>(int capacity) { throw null; }
        public static System.Threading.Channels.Channel<T> CreateBounded<T>(System.Threading.Channels.BoundedChannelOptions options) { throw null; }
        public static System.Threading.Channels.Channel<T> CreateBounded<T>(System.Threading.Channels.BoundedChannelOptions options, System.Action<T>? itemDropped) { throw null; }
        public static System.Threading.Channels.Channel<T> CreateUnbounded<T>() { throw null; }
        public static System.Threading.Channels.Channel<T> CreateUnbounded<T>(System.Threading.Channels.UnboundedChannelOptions options) { throw null; }
    }
    public partial class ChannelClosedException : System.InvalidOperationException
    {
        public ChannelClosedException() { }
        public ChannelClosedException(System.Exception? innerException) { }
        protected ChannelClosedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ChannelClosedException(string? message) { }
        public ChannelClosedException(string? message, System.Exception? innerException) { }
    }
    public abstract partial class ChannelOptions
    {
        protected ChannelOptions() { }
        public bool AllowSynchronousContinuations { get { throw null; } set { } }
        public bool SingleReader { get { throw null; } set { } }
        public bool SingleWriter { get { throw null; } set { } }
    }
    public abstract partial class ChannelReader<T>
    {
        protected ChannelReader() { }
        public virtual bool CanCount { get { throw null; } }
        public virtual bool CanPeek { get { throw null; } }
        public virtual System.Threading.Tasks.Task Completion { get { throw null; } }
        public virtual int Count { get { throw null; } }
        public virtual System.Collections.Generic.IAsyncEnumerable<T> ReadAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.ValueTask<T> ReadAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual bool TryPeek([System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out T item) { throw null; }
        public abstract bool TryRead([System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out T item);
        public abstract System.Threading.Tasks.ValueTask<bool> WaitToReadAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
    public abstract partial class ChannelWriter<T>
    {
        protected ChannelWriter() { }
        public void Complete(System.Exception? error = null) { }
        public virtual bool TryComplete(System.Exception? error = null) { throw null; }
        public abstract bool TryWrite(T item);
        public abstract System.Threading.Tasks.ValueTask<bool> WaitToWriteAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        public virtual System.Threading.Tasks.ValueTask WriteAsync(T item, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public abstract partial class Channel<T> : System.Threading.Channels.Channel<T, T>
    {
        protected Channel() { }
    }
    public abstract partial class Channel<TWrite, TRead>
    {
        protected Channel() { }
        public System.Threading.Channels.ChannelReader<TRead> Reader { get { throw null; } protected set { } }
        public System.Threading.Channels.ChannelWriter<TWrite> Writer { get { throw null; } protected set { } }
        public static implicit operator System.Threading.Channels.ChannelReader<TRead> (System.Threading.Channels.Channel<TWrite, TRead> channel) { throw null; }
        public static implicit operator System.Threading.Channels.ChannelWriter<TWrite> (System.Threading.Channels.Channel<TWrite, TRead> channel) { throw null; }
    }
    public sealed partial class UnboundedChannelOptions : System.Threading.Channels.ChannelOptions
    {
        public UnboundedChannelOptions() { }
    }
}
