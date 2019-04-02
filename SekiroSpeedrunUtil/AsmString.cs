using System.Linq;

namespace SekiroSpeedrunUtil {
    public class AsmString {
        public string Val { get; set; }
        public string RawVal { get; set; }

        public string[] Instructions { get; }

        public AsmString(string rawVal) {
            RawVal = rawVal;
            Val = string.Join("\n", RawVal.Split('\n').Select(s => s.TrimStart(' ')).Where(s => s != string.Empty));
            Instructions = Val.Split('\n');
        }

        public AsmString(string[] instructions) => Instructions = instructions;
    }

    public static class AsmStringExt {
        public static AsmString ToAsm(this string input) => new AsmString(input);
        public static AsmString ToAsm(this string[] input) => new AsmString(input);
    }
}
