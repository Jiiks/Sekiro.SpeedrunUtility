using System.Windows.Forms;

namespace SekiroSpeedrunUtil.structs {
    public class Hotkey {
        public string HotkeyString;
        public string Name;
        public Keys Key;
        public Keys Modifiers;
        public bool Invalid;
        public bool Unset;
    }
}
