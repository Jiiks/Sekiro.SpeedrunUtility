using System;
using System.Threading;
using System.Windows.Forms;

namespace SekiroSpeedrunUtil {
    public static class HotKeyManager  {

        public static event EventHandler<HotKeyEventArgs> HotKeyPressed;
        private static volatile MessageWindow _wnd;
        private static volatile IntPtr _hwnd;
        private static readonly ManualResetEvent _windowReadyEvent = new ManualResetEvent(false);

        public static int RegisterHotKey(Keys key, KeyModifiers modifiers) {
            _windowReadyEvent.WaitOne();
            var id = Interlocked.Increment(ref _id);
            _wnd.Invoke(new RegisterHotKeyDelegate(RegisterHotKeyInternal), _hwnd, id, (uint)modifiers, (uint)key);
            return id;
        }

        public static void UnregisterHotKey(int id) => _wnd.Invoke(new UnRegisterHotKeyDelegate(UnRegisterHotKeyInternal), _hwnd, id);

        private delegate void RegisterHotKeyDelegate(IntPtr hwnd, int id, uint modifiers, uint key);

        private delegate void UnRegisterHotKeyDelegate(IntPtr hwnd, int id);

        private static void RegisterHotKeyInternal(IntPtr hwnd, int id, uint modifiers, uint key) => Native.RegisterHotKey(hwnd, id, modifiers, key);

        private static void UnRegisterHotKeyInternal(IntPtr hwnd, int id) => Native.UnregisterHotKey(_hwnd, id);

        private static void OnHotKeyPressed(HotKeyEventArgs e) => HotKeyPressed?.Invoke(null, e);

        
        static HotKeyManager() {
            var messageLoop = new Thread(delegate () {
                Application.Run(new MessageWindow());
            }) {
                Name = "MessageLoopThread",
                IsBackground = true
            };
            messageLoop.Start();
        }

        private class MessageWindow : Form  {
            public MessageWindow() {
                _wnd = this;
                _hwnd = this.Handle;
                _windowReadyEvent.Set();
            }

            protected override void WndProc(ref Message m) {
                if (m.Msg == WM_HOTKEY) {
                    var e = new HotKeyEventArgs(m.LParam);
                    OnHotKeyPressed(e);
                }

                base.WndProc(ref m);
            }

            protected override void SetVisibleCore(bool value) => base.SetVisibleCore(false);

            private const int WM_HOTKEY = 0x312;
        }

        private static int _id;
    }


    public class HotKeyEventArgs : EventArgs
    {
        public readonly Keys Key;
        public readonly KeyModifiers Modifiers;

        public HotKeyEventArgs(Keys key, KeyModifiers modifiers = KeyModifiers.NoRepeat) {
            Key = key;
            Modifiers = modifiers;
        }

        public HotKeyEventArgs(IntPtr hotKeyParam) {
            var param = (uint)hotKeyParam.ToInt64();
            Key = (Keys)((param & 0xffff0000) >> 16);
            Modifiers = (KeyModifiers)(param & 0x0000ffff);
        }
    }

    [Flags]
    public enum KeyModifiers {
        Alt = 1,
        Control = 2,
        Shift = 4,
        Windows = 8,
        NoRepeat = 0x4000
    }
}
