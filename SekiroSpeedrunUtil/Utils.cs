using System;
using System.Diagnostics;
using System.IO;


namespace SekiroSpeedrunUtil {
    public static class Utils {

        public static Process Sekiro() {
            var processes = Process.GetProcessesByName("Sekiro");
            return processes.Length <= 0 ? null : processes[0];
        }

        public static Process ProcByName(string processName) {
            var processes = Process.GetProcessesByName(processName);
            return processes.Length <= 0 ? null : processes[0];
        }

        public static string DataDir() {
            var appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var ret = $"{appdataPath}/SekiroSpeedrunUtil";
            if (!Directory.Exists(ret)) Directory.CreateDirectory(ret);
            return ret;
        }

    }
}
