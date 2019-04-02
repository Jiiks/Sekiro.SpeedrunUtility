using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MemoryLibrary;
using MetroFramework;
using MetroFramework.Controls;
using SekiroSpeedrunUtil.structs;

namespace SekiroSpeedrunUtil.ui {
    public class Flag {

        public string Name;
        public string Text;
        public string Category;
        public byte Default;

        private IntPtrE _ptr;

        private FormMain _form;
        private MetroPanel _panel;
        private MetroCheckBox _checkBox;

        public void RenderFlag(FormMain form) {
            _ptr = Defs.PointerByName(Name);
            if (_ptr == null) {
                return;
            }
            _form = form;
            _panel = _form.Controls.Find(Category, true)[0] as MetroPanel;

            var chkd = Default;
            var sekiro = Utils.Sekiro();
            if (sekiro != null) {
                using (var remoteProc = new RemoteProcess(Utils.Sekiro())) {
                    chkd = remoteProc.Read<byte>(_ptr.BasePtr());
                }
            }

            _checkBox = new MetroCheckBox {
                Text = string.IsNullOrEmpty(Text) ? Name : Text,
                Checked = chkd > 0,
                Theme = MetroThemeStyle.Dark,
                Style = MetroColorStyle.Teal,
                AutoSize = false,
                Dock = DockStyle.Top,
                CheckAlign = ContentAlignment.MiddleRight
            };

            _checkBox.CheckedChanged += CheckBoxOnCheckedChanged;

            _panel.InvokeIfRequired(() => _panel.Controls.Add(_checkBox));
        }

        private bool _selfChange;
        private void CheckBoxOnCheckedChanged(object sender, EventArgs e) {
            if (_selfChange) {
                _selfChange = false;
                return;
            }
            var sekiro = Utils.Sekiro();
            if (sekiro == null) return;

            var next = _checkBox.Checked ? (byte) 0x01 : (byte) 0x00;

            if (Write(next)) return;
            _selfChange = true;
            _checkBox.Checked = !_checkBox.Checked;
        }

        private bool Write(byte b) {
            var sekiro = Utils.Sekiro();
            if (sekiro == null) return false;

            try {
                using (var remoteProc = new RemoteProcess(sekiro)) {
                    remoteProc.Write(_ptr.BasePtr(), b);
                } return true;
            }
            catch (Exception e) {
                Debug.WriteLine($"Could not set flag {Name}");
                return false;
            }
        }

        private byte Read(byte b) {
            var sekiro = Utils.Sekiro();
            if (sekiro == null) return Default;

            try {
                using (var remoteProc = new RemoteProcess(Utils.Sekiro())) {
                    return remoteProc.Read<byte>(_ptr.BasePtr());
                }
            } catch (Exception e) {
                return Default;
            }
        }
    }
}
