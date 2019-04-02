namespace SekiroSpeedrunUtil.injects {
    internal class InjectBase {

        protected AsmString _asm = null;

        public void Execute() {
            if (_asm == null) return;
            Asm.ExecuteAsm("Sekiro", _asm);
        }

    }
}
