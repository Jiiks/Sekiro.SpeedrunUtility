using System;

namespace SekiroSpeedrunUtil.structs {
    public class Ptr : IntPtrE {
        public Ptr(long ptr, params int[] offsets) : base(ptr, offsets) { }
        public Ptr(IntPtr ptr, params int[] offsets) : base(ptr, offsets) { }
    }
}
