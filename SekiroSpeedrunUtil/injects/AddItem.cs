using SekiroSpeedrunUtil.structs;

namespace SekiroSpeedrunUtil.injects {
    class AddItem : InjectBase  {

        public AddItem(Item item, int quantity) {
            if (item.Consumable) {
                _asm = GenerateConsumableAsm(item.ShortId(), quantity);
                return;
            }

            Diag.WriteLine(((int)item.Id2).ToString("X"));
            _asm = GenerateProsteticAsm((int)item.Id2);
        }

        private static AsmString GenerateConsumableAsm(int id, int quantity) {
            return new AsmString($@"
                                        mov edx,0x2
                                        mov rcx, 0x143B47CF0
                                        mov rcx, [rcx]
                                        mov rcx, [rcx+0x8]
                                        lea rcx, [rcx+0x270]
                                        mov word [rcx+0x10],0x0
                                        mov word [rcx+0x12],0x4000
                                        mov word [rcx+0x14],{id}
                                        mov word [rcx+0x18],{quantity}
                                        mov word [rcx+0x24],0x1
                                        sub rsp, 0x58
                                        mov rax, 0x14079A090
                                        call rax
                                        add rsp, 0x58
                                        ret");
        }

        private static AsmString GenerateProsteticAsm(int id) {
            return new AsmString($@"
                                        mov edx,0x2
                                        mov rcx, 0x143B47CF0
                                        mov rcx, [rcx]
                                        mov rcx, [rcx+0x8]
                                        lea rcx, [rcx+0x270]
                                        mov word [rcx+0x10],0x0
                                        mov word [rcx+0x12],0x0
                                        mov word [rcx+0x14],{id}
                                        mov word [rcx+0x18],0x1
                                        mov word [rcx+0x24],0x1
                                        sub rsp, 0x58
                                        mov rax, 0x14079A090
                                        call rax
                                        add rsp, 0x58
                                        ret");
        }

    }
}
