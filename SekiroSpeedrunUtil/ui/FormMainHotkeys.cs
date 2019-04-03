using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SekiroSpeedrunUtil.ui {
    public partial class FormMain  {

        private HotkeyStruct _saveCurrentCoordinates;
        private HotkeyStruct _teleportToCoordinates;
        private HotkeyStruct _backupSave;
        private HotkeyStruct _loadSave;
        private HotkeyStruct _loadQuick;
        private HotkeyStruct _forceQuit;

        public void InitHotkeys() {

            var hotkeyFile = "hotkeys.json";
            if (File.Exists($"{Utils.DataDir()}/hotkeys.json")) hotkeyFile = $"{Utils.DataDir()}/hotkeys.json";

            var loadHotkeys = JsonConvert.DeserializeObject<HotkeyStruct[]>(File.ReadAllText(hotkeyFile));
            foreach (var hotkeyStruct in loadHotkeys) {
                switch (hotkeyStruct.Name) {
                    case "SaveCurrentCoordinates":
                        _saveCurrentCoordinates = hotkeyStruct;
                        _saveCurrentCoordinates.Id = HotKeyManager.RegisterHotKey(hotkeyStruct.Key, hotkeyStruct.Modifiers);
                        hotkeySaveCurrentCoordinates.InvokeIfRequired(() => {
                            hotkeySaveCurrentCoordinates.Text = hotkeyStruct.HotkeyString;
                        });
                        break;
                    case "TeleportToCoordinates":
                        _teleportToCoordinates = hotkeyStruct;
                        _teleportToCoordinates.Id = HotKeyManager.RegisterHotKey(hotkeyStruct.Key, hotkeyStruct.Modifiers);
                        hotkeyTeleportToCoordinates.InvokeIfRequired(() => {
                            hotkeyTeleportToCoordinates.Text = hotkeyStruct.HotkeyString;
                        });
                        break;
                    case "LoadSave":
                        _loadSave = hotkeyStruct;
                        _loadSave.Id = HotKeyManager.RegisterHotKey(hotkeyStruct.Key, hotkeyStruct.Modifiers);
                        hotkeyLoadSave.InvokeIfRequired(() => {
                            hotkeyLoadSave.Text = hotkeyStruct.HotkeyString;
                        });
                        break;
                    case "BackupSave":
                        _backupSave = hotkeyStruct;
                        _backupSave.Id = HotKeyManager.RegisterHotKey(hotkeyStruct.Key, hotkeyStruct.Modifiers);
                        hotkeyBackupSave.InvokeIfRequired(() => {
                            hotkeyBackupSave.Text = hotkeyStruct.HotkeyString;
                        });
                        break;
                    case "LoadLastQuickSave":
                        _loadQuick = hotkeyStruct;
                        _loadQuick.Id = HotKeyManager.RegisterHotKey(hotkeyStruct.Key, hotkeyStruct.Modifiers);
                        hotkeyLoadQuick.InvokeIfRequired(() => {
                            hotkeyLoadQuick.Text = hotkeyStruct.HotkeyString;
                        });
                        break;
                    case "ForceQuit":
                        _forceQuit = hotkeyStruct;
                        _forceQuit.Id = HotKeyManager.RegisterHotKey(hotkeyStruct.Key, hotkeyStruct.Modifiers);
                        hotkeyQuit.InvokeIfRequired(() => {
                            hotkeyQuit.Text = hotkeyStruct.HotkeyString;
                        });
                        break;
                }
            }

            hotkeySaveCurrentCoordinates.KeyDown += HotkeySaveCurrentCoordinatesOnKeyDown;
            hotkeyTeleportToCoordinates.KeyDown += HotkeyTeleportToCoordinatesOnKeyDown;
            hotkeyBackupSave.KeyDown += HotkeyBackupSaveOnKeyDown;
            hotkeyLoadSave.KeyDown += HotkeyLoadSaveOnKeyDown;
            hotkeyLoadQuick.KeyDown += HotkeyLoadQuickOnKeyDown;
            hotkeyQuit.KeyDown += HotkeyQuitOnKeyDown;

            HotKeyManager.HotKeyPressed += (sender, e) => {
                mainTabControl.InvokeIfRequired(() => {
                    if (mainTabControl.SelectedTab == pageHotkeys) return;
                    HotkeyPressed(sender, e);
                });
            };

            FormClosing += (sender, args) => {
                if (_saveCurrentCoordinates.Id > 0) {
                    HotKeyManager.UnregisterHotKey(_saveCurrentCoordinates.Id);
                }
            };
        }

        private void HotkeyQuitOnKeyDown(object sender, KeyEventArgs e) {
            var hotkey = ResolveHotkey(e);
            if (hotkey.Invalid) return;
            if (hotkey.Clear) {
                hotkeyQuit.Text = "";
                metroLabel9.Focus();
                return;
            }

            hotkeyQuit.Text = hotkey.HotkeyString;

            if (_loadSave.Id > 0) {
                HotKeyManager.UnregisterHotKey(_forceQuit.Id);
            }

            _forceQuit = hotkey;
            _forceQuit.Name = "ForceQuit";
            _forceQuit.Id = HotKeyManager.RegisterHotKey(hotkey.Key, hotkey.Modifiers);
            metroLabel9.Focus();
            SaveHotkeys();
        }

        private void HotkeyLoadSaveOnKeyDown(object sender, KeyEventArgs e) {
            var hotkey = ResolveHotkey(e);
            if (hotkey.Invalid) return;
            if (hotkey.Clear) {
                hotkeyLoadSave.Text = "";
                metroLabel9.Focus();
                return;
            }

            hotkeyLoadSave.Text = hotkey.HotkeyString;

            if (_loadSave.Id > 0) {
                HotKeyManager.UnregisterHotKey(_loadSave.Id);
            }

            _loadSave = hotkey;
            _loadSave.Name = "LoadSave";
            _loadSave.Id = HotKeyManager.RegisterHotKey(hotkey.Key, hotkey.Modifiers);
            metroLabel9.Focus();
            SaveHotkeys();
        }

        private void HotkeyLoadQuickOnKeyDown(object sender, KeyEventArgs e) {
            var hotkey = ResolveHotkey(e);
            if (hotkey.Invalid) return;
            if (hotkey.Clear) {
                hotkeyLoadQuick.Text = "";
                metroLabel9.Focus();
                return;
            }

            hotkeyLoadQuick.Text = hotkey.HotkeyString;

            if (_loadQuick.Id > 0) {
                HotKeyManager.UnregisterHotKey(_loadQuick.Id);
            }

            _loadQuick = hotkey;
            _loadQuick.Name = "LoadLastQuickSave";
            _loadQuick.Id = HotKeyManager.RegisterHotKey(hotkey.Key, hotkey.Modifiers);
            metroLabel9.Focus();
            SaveHotkeys();
        }

        private void HotkeyBackupSaveOnKeyDown(object sender, KeyEventArgs e) {
            var hotkey = ResolveHotkey(e);
            if (hotkey.Invalid) return;
            if (hotkey.Clear) {
                hotkeyBackupSave.Text = "";
                metroLabel9.Focus();
                return;
            }

            hotkeyBackupSave.Text = hotkey.HotkeyString;

            if (_backupSave.Id > 0) {
                HotKeyManager.UnregisterHotKey(_backupSave.Id);
            }

            _backupSave = hotkey;
            _backupSave.Name = "BackupSave";
            _backupSave.Id = HotKeyManager.RegisterHotKey(hotkey.Key, hotkey.Modifiers);
            metroLabel9.Focus();
            SaveHotkeys();
        }

        private void SaveHotkeys() {
            File.WriteAllText($"{Utils.DataDir()}/hotkeys.json", JsonConvert.SerializeObject(new[] {
                _saveCurrentCoordinates,
                _teleportToCoordinates,
                _backupSave,
                _loadSave,
                _loadQuick,
                _forceQuit
            }));
        }

        private void HotkeyPressed(object sender, HotKeyEventArgs e) {
            if (e.Key == _saveCurrentCoordinates.Key && e.Modifiers == _saveCurrentCoordinates.Modifiers) {
                btnLoadCurrentCoords.InvokeIfRequired(() => btnLoadCurrentCoords.PerformClick());
                return;
            }

            if (e.Key == _teleportToCoordinates.Key && e.Modifiers == _teleportToCoordinates.Modifiers) {
                btnTeleportToCoordinates.InvokeIfRequired(() => btnTeleportToCoordinates.PerformClick());
                return;
            }

            if (e.Key == _loadSave.Key && e.Modifiers == _loadSave.Modifiers) {
                QuickLoad();
                return;
            }

            if (e.Key == _backupSave.Key && e.Modifiers == _backupSave.Modifiers) {
                QuickSave();
                return;
            }

            if (e.Key == _loadQuick.Key && e.Modifiers == _loadQuick.Modifiers) {
                QuickLoadQuick();
                return;
            }

            if (e.Key == _forceQuit.Key && e.Modifiers == _forceQuit.Modifiers) {
                ForceQuit();
                return;
            }
        }

        private void ForceQuit() {
            var rp = RemoteProc.Instance();
            if (rp == null) return;

            rp.Write(Defs.PointerByName("QuitToTitle").GetAddress(rp), (byte)1);
        }

        private void HotkeySaveCurrentCoordinatesOnKeyDown(object sender, KeyEventArgs e) {
            var hotkey = ResolveHotkey(e);
            if (hotkey.Invalid) return;
            if (hotkey.Clear) {
                hotkeySaveCurrentCoordinates.Text = "";
                metroLabel9.Focus();
                return;
            }

            hotkeySaveCurrentCoordinates.Text = hotkey.HotkeyString;

            if (_saveCurrentCoordinates.Id > 0) {
                HotKeyManager.UnregisterHotKey(_saveCurrentCoordinates.Id);
            }

            _saveCurrentCoordinates = hotkey;
            _saveCurrentCoordinates.Name = "SaveCurrentCoordinates";
            _saveCurrentCoordinates.Id = HotKeyManager.RegisterHotKey(hotkey.Key, hotkey.Modifiers);
            metroLabel9.Focus();
            SaveHotkeys();
        }

        private void HotkeyTeleportToCoordinatesOnKeyDown(object sender, KeyEventArgs e) {
            var hotkey = ResolveHotkey(e);
            if (hotkey.Invalid) return;
            if (hotkey.Clear) {
                hotkeyTeleportToCoordinates.Text = "";
                metroLabel9.Focus();
                return;
            }

            hotkeyTeleportToCoordinates.Text = hotkey.HotkeyString;

            if (_teleportToCoordinates.Id > 0) {
                HotKeyManager.UnregisterHotKey(_teleportToCoordinates.Id);
            }

            _teleportToCoordinates = hotkey;
            _teleportToCoordinates.Name = "TeleportToCoordinates";
            _teleportToCoordinates.Id = HotKeyManager.RegisterHotKey(hotkey.Key, hotkey.Modifiers);
            metroLabel9.Focus();
            SaveHotkeys();
        }

        private static HotkeyStruct ResolveHotkey(KeyEventArgs e) {
            var converter = new KeysConverter();
            var keyString = converter.ConvertToString(e.KeyCode);
            if (keyString == null) return new HotkeyStruct { Invalid = true };
            if (keyString.Contains("Shift") || keyString.Contains("Menu") || keyString.Contains("Control") || keyString.Contains("Alt")) return new HotkeyStruct() { Invalid = true };
            if (e.KeyCode == Keys.Escape) return new HotkeyStruct { Clear = true };

            var hotkey = new HotkeyStruct() {
                Key = e.KeyCode
            };

            switch (e.Modifiers) {
                case Keys.Shift:
                    hotkey.HotkeyString = $"Shift+{keyString}";
                    hotkey.Modifiers = KeyModifiers.Shift;
                    break;
                case Keys.Control:
                    hotkey.HotkeyString = $"Ctrl+{keyString}";
                    hotkey.Modifiers = KeyModifiers.Control;
                    break;
                case Keys.Alt:
                    hotkey.HotkeyString = $"Alt+{keyString}";
                    hotkey.Modifiers = KeyModifiers.Alt;
                    break;
                case Keys.Control | Keys.Shift:
                    hotkey.HotkeyString = $"Ctrl+Shift+{keyString}";
                    hotkey.Modifiers = KeyModifiers.Control & KeyModifiers.Shift;
                    break;
                case Keys.Control | Keys.Alt:
                    hotkey.HotkeyString = $"Ctrl+Alt+{keyString}";
                    hotkey.Modifiers = KeyModifiers.Control & KeyModifiers.Alt;
                    break;
                case Keys.Shift | Keys.Alt:
                    hotkey.HotkeyString = $"Shift+Alt+{keyString}";
                    hotkey.Modifiers = KeyModifiers.Shift & KeyModifiers.Alt;
                    break;
                case Keys.Shift | Keys.Alt | Keys.Control:
                    hotkey.HotkeyString = $"Ctrl+Alt+Shift+{keyString}";
                    hotkey.Modifiers = KeyModifiers.Shift & KeyModifiers.Alt & KeyModifiers.Control;
                    break;
                default:
                    hotkey.HotkeyString = keyString;
                    break;
            }

            return hotkey;
        }

        public struct HotkeyStruct {
            public string HotkeyString;
            public string Name;
            public Keys Key;
            public KeyModifiers Modifiers;
            [JsonIgnore]
            public bool Invalid;
            [JsonIgnore]
            public bool Clear;
            [JsonIgnore]
            public int Id;
        }
    }
}
