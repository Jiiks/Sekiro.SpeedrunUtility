using SekiroSpeedrunUtil.structs;

namespace SekiroSpeedrunUtil.injects {
    internal class IdolTeleport : InjectBase {

        public IdolTeleport(Idol idol) {
            _asm = new AsmString(GenerateAsm(idol.Id - 1000));
        }

        private static string GenerateAsm(int id) {
            return $@"
                sub rsp,0x38
                mov rdx,{id}
                mov rax,0x14068C410
                call rax
                add rsp,0x38
                ret";
        }

    }
}
