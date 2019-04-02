using System.Diagnostics;
using SekiroSpeedrunUtil.ui;

namespace SekiroSpeedrunUtil {
    public static class Diag {
        public static void WriteLine(string msg) {
            FormMain.Debug(msg);
            Debug.WriteLine(msg);
        }
    }
}
