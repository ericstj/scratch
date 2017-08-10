using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tensorInterop
{
    internal sealed class NativeAllocator<T> : IDisposable
    {
        private Dictionary<IntPtr, GCHandle> allocated;

        ~NativeAllocator()
        {
            Debug.Fail($"{nameof(NativeAllocator<T>)} was not disposed, which left pinned objects on the heap longer than necessary.");
            Dispose(false);
        }

        public IntPtr AllocateArray(int size)
        {
            var value = new T[size];

            // pin the allocated array since we're handing it back to native code.
            var handle = GCHandle.Alloc(value, GCHandleType.Pinned);

            var address = handle.AddrOfPinnedObject();

            if (allocated == null)
            {
                allocated = new Dictionary<IntPtr, GCHandle>();
            }
            allocated.Add(address, handle);

            return address;
        }
        
        public T[] Unpin(IntPtr address)
        {
            GCHandle handle;

            if (!allocated.TryGetValue(address, out handle))
            {
                throw new InvalidOperationException($"Could not unpin address {address} as it was not a known object allocated by this {nameof(NativeAllocator<T>)}.");
            }
            else
            {
                allocated.Remove(address);
                var result = (T[])handle.Target;
                handle.Free();
                return result;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        { 
            if (allocated != null)
            {
                foreach(var handle in allocated.Values)
                {
                    handle.Free();
                }

                allocated = null;
            }
        }
    }
}
