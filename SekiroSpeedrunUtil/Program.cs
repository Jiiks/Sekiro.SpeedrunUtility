using System;
using System.Windows.Forms;
using SekiroSpeedrunUtil.ui;

namespace SekiroSpeedrunUtil {
    static class Program {

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
