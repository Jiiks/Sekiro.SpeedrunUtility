using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SekiroSpeedrunUtil {
    internal class MouseDetector {
        #region APIs

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool GetCursorPos(out Point pt);

        #endregion

        private readonly Timer _tm = new Timer() { Interval = 50 };
        public delegate void MouseMoveDLG(object sender, System.Drawing.Point p);
        public event MouseMoveDLG MouseMove;
        public MouseDetector() {
            _tm.Tick += Tm_Tick; _tm.Start();
        }

        private void Tm_Tick(object sender, EventArgs e) {
            GetCursorPos(out var p);
            MouseMove?.Invoke(this, new System.Drawing.Point(p.X, p.Y));
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Point  {
            public int X;
            public int Y;
        }
    }
}
