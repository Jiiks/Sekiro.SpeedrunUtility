using System.Diagnostics;
using MemoryLibrary;

namespace SekiroSpeedrunUtil {
    public class Asm {
        public static void ExecuteAsm(string procName, AsmString asm) {
            var proc = Process.GetProcessesByName("Sekiro");
            if (proc.Length <= 0) return;
            proc[0].ExecuteAsm(asm);
        }
    }
    public static class AsmExt {
        public static void ExecuteAsm(this Process proc, string rawString) => proc.ExecuteAsm(rawString.ToAsm());
        public static void ExecuteAsm(this Process proc, string[] instructions) => proc.ExecuteAsm(instructions.ToAsm());
        public static void ExecuteAsm(this Process proc, AsmString asm) {
            using (var remoteProc = new RemoteProcess(proc))
            using (var transactor = remoteProc.Assembly.BeginTransaction()) {
                foreach (var instruction in asm.Instructions) {
                    transactor.AddLine(instruction);
                }
            }
        }
    }
}
