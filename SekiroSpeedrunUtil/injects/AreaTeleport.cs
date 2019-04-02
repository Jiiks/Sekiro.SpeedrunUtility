using System;
using SekiroSpeedrunUtil.structs;

namespace SekiroSpeedrunUtil.injects {
    internal class AreaTeleport : InjectBase {

        public AreaTeleport(byte id0, byte id1) {
            _asm = new AsmString(GenerateAsm(new Tuple<byte, byte>(id0, id1)));
        }

        public AreaTeleport(Area area) {
            _asm = new AsmString(GenerateAsm(new Tuple<byte, byte>(area.Id0, area.Id1)));
        }

        private static string GenerateAsm(Tuple<byte, byte> ids) {
            var (item1, item2) = ids;
            return $@"
                sub rsp,0x38
                mov edx,{item1}
                mov r8d,{item2}
                mov r9d,0x00
                mov ebx,0x00
                mov edi,0x1121F0
                mov [rsp+0x28],edi
                mov [rsp+0x20],ebx
                mov rax,0x14068C390
                call rax
                add rsp,0x38
                ret";
        }

    }
}
