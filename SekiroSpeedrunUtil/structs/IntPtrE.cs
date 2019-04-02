using System;
using System.Diagnostics;
using System.Linq;
using MemoryLibrary;

namespace SekiroSpeedrunUtil.structs {
    public class IntPtrE {

        private readonly IntPtr _ptr;
        public IntPtr BasePtr() => _ptr;
        private readonly int[] _offsets;
        public int[] Offests() => _offsets;

        public IntPtrE(long ptr, params int[] offsets) : this(new IntPtr(ptr), offsets) { }
        public IntPtrE(IntPtr ptr, params int[] offsets) {
            _ptr = ptr;
            _offsets = offsets;
        }

        public IntPtr GetAddress(Process proc) {
            try {
                if (proc.HasExited) return IntPtr.Zero;
                using (var remoteProc = new RemoteProcess(proc)) {
                    if (_offsets == null || _offsets.Length <= 0) return remoteProc.Read<IntPtr>(_ptr);
                    return _offsets.Aggregate(_ptr, (current, offset) => remoteProc.Read<IntPtr>(current) + offset);
                }
            } catch (Exception) {
                return IntPtr.Zero;
            }
        }
    }

    public static class InptrEE {
        public static IntPtrE Ptr(this long ptr) => new IntPtrE(ptr, null);
        public static IntPtrE Ptr(this long ptr, params int[] offsets) => new IntPtrE(ptr, offsets);
    }
}
