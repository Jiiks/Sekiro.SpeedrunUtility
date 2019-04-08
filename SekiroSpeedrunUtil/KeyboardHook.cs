using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Newtonsoft.Json;
using SekiroSpeedrunUtil.structs;

namespace SekiroSpeedrunUtil {
    public class KeyboardHook : IDisposable {

        //private List<Hotkey> _hotkeys;

        public KeyboardHook() {
            _keyboardProc = Callback;
            /*
            _keyboardProc = Callback;
            var hotkeyFile = "hotkeys2.json";
            if (File.Exists($"{Utils.DataDir()}/hotkeys2.json")) hotkeyFile = $"{Utils.DataDir()}/hotkeys2.json";

            _hotkeys = JsonConvert.DeserializeObject <List<Hotkey>>(File.ReadAllText(hotkeyFile));
            */
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(int idHook, KeyboardHook.KeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx(IntPtr hookId);

        [DllImport("user32", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CallNextHookEx(IntPtr hookId, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern short GetKeyState(int keyCode);

        //Modifier key vkCode constants
        private const int VK_SHIFT = 0x10;
        private const int VK_CONTROL = 0x11;
        private const int VK_MENU = 0x12;
        private const int VK_CAPITAL = 0x14;

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;

        public delegate IntPtr KeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private Keys GetModifiers () {
            var key = new Keys();
            if ((GetKeyState(VK_SHIFT) & 0x8000) != 0) key |= Keys.Shift;
            if ((GetKeyState(VK_CONTROL) & 0x8000) != 0) key |= Keys.Control;
            if ((GetKeyState(VK_MENU) & 0x8000) != 0) key |= Keys.Alt;
            return key;
        }

        public event EventHandler<KeyPressEventArgs> OnKeyPressed;

        private static KeyboardProc _keyboardProc;
        private IntPtr _hookId = IntPtr.Zero;

        public void Hook() {
            _hookId = SetWindowsHookEx(WH_KEYBOARD_LL, _keyboardProc, IntPtr.Zero, 0);
        }


        private IntPtr Callback(int nCode, IntPtr wParam, IntPtr lParam) {
            if(nCode < 0 || wParam != (IntPtr)WM_KEYDOWN) return CallNextHookEx(_hookId, nCode, wParam, lParam);

            try {
                var vkCode = Marshal.ReadInt32(lParam);
                var eargs = new KeyPressEventArgs {
                    KeyPressed = (Keys)vkCode,
                    Modifiers = GetModifiers()
                };
                var modifiers = GetModifiers();
                OnKeyPressed?.Invoke(this, eargs);
            } catch (Exception ex) {
                Diag.WriteLine($"[KeyboardHook] {ex.Message}");
            }

            return CallNextHookEx(_hookId, nCode, wParam, lParam);
        }

        public void Dispose() {
            if (_hookId == IntPtr.Zero) return;
            UnhookWindowsHookEx(_hookId);
        }

        public struct KeyPressEventArgs {
            public Keys KeyPressed;
            public Keys Modifiers;
        }

        /*
        public class KeyPressedArgs : EventArgs {
            public Key KeyPressed { get; }

            public KeyPressedArgs(Key key) {
                KeyPressed = key;
            }
        }
        */
    }
}
