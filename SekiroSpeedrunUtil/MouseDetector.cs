using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SekiroSpeedrunUtil
{
    class MouseDetector
    {
        #region APIs

        [DllImport("gdi32")]
        public static extern uint GetPixel(IntPtr hDC, int XPos, int YPos);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool GetCursorPos(out POINT pt);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        #endregion

        Timer tm = new Timer() { Interval = 10 };
        public delegate void MouseMoveDLG(object sender, Point p);
        public event MouseMoveDLG MouseMove;
        public MouseDetector() {
            tm.Tick += new EventHandler(tm_Tick); tm.Start();
        }

        void tm_Tick(object sender, EventArgs e) {
            POINT p;
            GetCursorPos(out p);
            if (MouseMove != null) MouseMove(this, new Point(p.X, p.Y));
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;
            public POINT(int x, int y) {
                X = x;
                Y = y;
            }
        }
    }
}
