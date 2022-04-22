// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// ------------------------------------------------------------------------------
// Changes to this file must follow the https://aka.ms/api-review process.
// ------------------------------------------------------------------------------

namespace System.Threading
{
    public partial class Barrier : System.IDisposable
    {
        public Barrier(int participantCount) { }
        public Barrier(int participantCount, System.Action<System.Threading.Barrier>? postPhaseAction) { }
        public long CurrentPhaseNumber { get { throw null; } }
        public int ParticipantCount { get { throw null; } }
        public int ParticipantsRemaining { get { throw null; } }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public long AddParticipant() { throw null; }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public long AddParticipants(int participantCount) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void RemoveParticipant() { }
        public void RemoveParticipants(int participantCount) { }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public void SignalAndWait() { }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public bool SignalAndWait(int millisecondsTimeout) { throw null; }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public bool SignalAndWait(int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { throw null; }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public void SignalAndWait(System.Threading.CancellationToken cancellationToken) { }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public bool SignalAndWait(System.TimeSpan timeout) { throw null; }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public bool SignalAndWait(System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class BarrierPostPhaseException : System.Exception
    {
        public BarrierPostPhaseException() { }
        public BarrierPostPhaseException(System.Exception? innerException) { }
        protected BarrierPostPhaseException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public BarrierPostPhaseException(string? message) { }
        public BarrierPostPhaseException(string? message, System.Exception? innerException) { }
    }
    public partial class CountdownEvent : System.IDisposable
    {
        public CountdownEvent(int initialCount) { }
        public int CurrentCount { get { throw null; } }
        public int InitialCount { get { throw null; } }
        public bool IsSet { get { throw null; } }
        public System.Threading.WaitHandle WaitHandle { get { throw null; } }
        public void AddCount() { }
        public void AddCount(int signalCount) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void Reset() { }
        public void Reset(int count) { }
        public bool Signal() { throw null; }
        public bool Signal(int signalCount) { throw null; }
        public bool TryAddCount() { throw null; }
        public bool TryAddCount(int signalCount) { throw null; }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public void Wait() { }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public bool Wait(int millisecondsTimeout) { throw null; }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public bool Wait(int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { throw null; }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public void Wait(System.Threading.CancellationToken cancellationToken) { }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public bool Wait(System.TimeSpan timeout) { throw null; }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public bool Wait(System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class HostExecutionContext : System.IDisposable
    {
        public HostExecutionContext() { }
        public HostExecutionContext(object? state) { }
        protected internal object? State { get { throw null; } set { } }
        public virtual System.Threading.HostExecutionContext CreateCopy() { throw null; }
        public void Dispose() { }
        public virtual void Dispose(bool disposing) { }
    }
    public partial class HostExecutionContextManager
    {
        public HostExecutionContextManager() { }
        public virtual System.Threading.HostExecutionContext? Capture() { throw null; }
        public virtual void Revert(object previousState) { }
        public virtual object SetHostExecutionContext(System.Threading.HostExecutionContext hostExecutionContext) { throw null; }
    }
    public partial struct LockCookie : System.IEquatable<System.Threading.LockCookie>
    {
        private int _dummyPrimitive;
        public override bool Equals([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] object? obj) { throw null; }
        public bool Equals(System.Threading.LockCookie obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Threading.LockCookie a, System.Threading.LockCookie b) { throw null; }
        public static bool operator !=(System.Threading.LockCookie a, System.Threading.LockCookie b) { throw null; }
    }
    public sealed partial class ReaderWriterLock : System.Runtime.ConstrainedExecution.CriticalFinalizerObject
    {
        public ReaderWriterLock() { }
        public bool IsReaderLockHeld { get { throw null; } }
        public bool IsWriterLockHeld { get { throw null; } }
        public int WriterSeqNum { get { throw null; } }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public void AcquireReaderLock(int millisecondsTimeout) { }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public void AcquireReaderLock(System.TimeSpan timeout) { }
        public void AcquireWriterLock(int millisecondsTimeout) { }
        public void AcquireWriterLock(System.TimeSpan timeout) { }
        public bool AnyWritersSince(int seqNum) { throw null; }
        public void DowngradeFromWriterLock(ref System.Threading.LockCookie lockCookie) { }
        public System.Threading.LockCookie ReleaseLock() { throw null; }
        public void ReleaseReaderLock() { }
        public void ReleaseWriterLock() { }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public void RestoreLock(ref System.Threading.LockCookie lockCookie) { }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public System.Threading.LockCookie UpgradeToWriterLock(int millisecondsTimeout) { throw null; }
        [System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
        public System.Threading.LockCookie UpgradeToWriterLock(System.TimeSpan timeout) { throw null; }
    }
}
