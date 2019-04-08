using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using SekiroSpeedrunUtil.structs;

namespace SekiroSpeedrunUtil.ui {
    public partial class FormMain  {

        private HotkeyStruct _saveCurrentCoordinates;
        private HotkeyStruct _teleportToCoordinates;
        private HotkeyStruct _backupSave;
        private HotkeyStruct _loadSave;
        private HotkeyStruct _loadQuick;
        private HotkeyStruct _forceQuit;
        private HotkeyStruct _flagToggle;

        private KeyboardHook _keyboardHook;
        private List<Hotkey> _hotkeys;

        public void InitHotkeys() {
            Diag.WriteLine("Init Hotkeys");
            mainTabControl.SelectedIndexChanged += (sender, args) => {
                _hotkeysDisabled = mainTabControl.SelectedIndex == 1;
            };
            _keyboardHook = new KeyboardHook();
            _keyboardHook.OnKeyPressed += OnKeyPressed;

            _keyboardHook.Hook();
            FormClosing += (sender, args) => _keyboardHook.Dispose();

            var defaultHotkeys = JsonConvert.DeserializeObject<List<Hotkey>>(File.ReadAllText("hotkeys.json"));
            _hotkeys = defaultHotkeys;
            if (File.Exists($@"{Utils.DataDir()}/hotkeysv2.json")) {
                var userHotkeys = JsonConvert.DeserializeObject<Hotkey[]>(File.ReadAllText($@"{Utils.DataDir()}/hotkeysv2.json"));
                foreach (var userHotkey in userHotkeys) {
                    var index = HotkeyIndex(userHotkey.Name);
                    if (index < 0) {
                        _hotkeys.Add(userHotkey);
                        continue;
                    }

                    ReplaceHotkey(userHotkey.Name, userHotkey);
                }
            }

            foreach (var hotkey in _hotkeys) {
                switch (hotkey.Name) {
                    case "SaveCurrentCoordinates":
                        hotkeySaveCurrentCoordinates.InvokeIfRequired(() => {
                            hotkeySaveCurrentCoordinates.Text = hotkey.HotkeyString;
                        });
                        break;
                    case "TeleportToCoordinates":
                        hotkeyTeleportToCoordinates.InvokeIfRequired(() => {
                            hotkeyTeleportToCoordinates.Text = hotkey.HotkeyString;
                        });
                        break;
                    case "LoadSave":
                        hotkeyLoadSave.InvokeIfRequired(() => {
                            hotkeyLoadSave.Text = hotkey.HotkeyString;
                        });
                        break;
                    case "BackupSave":
                        hotkeyBackupSave.InvokeIfRequired(() => {
                            hotkeyBackupSave.Text = hotkey.HotkeyString;
                        });
                        break;
                    case "LoadLastQuickSave":
                        hotkeyLoadQuick.InvokeIfRequired(() => {
                            hotkeyLoadQuick.Text = hotkey.HotkeyString;
                        });
                        break;
                    case "ForceQuit":
                        hotkeyQuit.InvokeIfRequired(() => {
                            hotkeyQuit.Text = hotkey.HotkeyString;
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
        }

        private Hotkey HotkeyByName(string name) {
            return _hotkeys.Find(hk => hk.Name == name);
        }

        private int HotkeyIndex(string name) {
            return _hotkeys.FindIndex(hk => hk.Name == name);
        }

        private void ReplaceHotkey(string name, Hotkey hotkey) {
            var index = HotkeyIndex(name);
            _hotkeys[index] = hotkey;
            SaveHotkeys2();
        }

        private bool _hotkeysDisabled;
        private void OnKeyPressed(object sender, KeyboardHook.KeyPressEventArgs e) {
            if (_hotkeysDisabled) return;
            foreach (var hotkey in _hotkeys) {
                if(hotkey.Unset || hotkey.Key != e.KeyPressed || hotkey.Modifiers != e.Modifiers) continue;
                HotkeyPressed(hotkey);
                return;
            }
        }

        private void HotkeyPressed(Hotkey hotkey) {
            switch (hotkey.Name) {
                case "SaveCurrentCoordinates":
                    btnLoadCurrentCoords.InvokeIfRequired(() => btnLoadCurrentCoords.PerformClick());
                    break;
                case "TeleportToCoordinates":
                    btnTeleportToCoordinates.InvokeIfRequired(() => btnTeleportToCoordinates.PerformClick());
                    break;
                case "BackupSave":
                    QuickSave();
                    break;
                case "LoadSave":
                    QuickLoad();
                    break;
                case "LoadLastQuickSave":
                    QuickLoadQuick();
                    break;
                case "ForceQuit":
                    ForceQuit();
                    break;
            }
        }

        public void InitHotkeys2() {

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
                    /*case "FlagToggle":
                        _flagToggle = hotkeyStruct;
                        _flagToggle.Id = HotKeyManager.RegisterHotKey(hotkeyStruct.Key, hotkeyStruct.Modifiers);
                        flagToggle.InvokeIfRequired(() => {
                            flagToggle.Text = hotkeyStruct.HotkeyString;
                        });
                        break;*/
                }
            }

            hotkeySaveCurrentCoordinates.KeyDown += HotkeySaveCurrentCoordinatesOnKeyDown;
            hotkeyTeleportToCoordinates.KeyDown += HotkeyTeleportToCoordinatesOnKeyDown;
            hotkeyBackupSave.KeyDown += HotkeyBackupSaveOnKeyDown;
            hotkeyLoadSave.KeyDown += HotkeyLoadSaveOnKeyDown;
            hotkeyLoadQuick.KeyDown += HotkeyLoadQuickOnKeyDown;
            hotkeyQuit.KeyDown += HotkeyQuitOnKeyDown;
            //flagToggle.KeyDown += FlagToggleOnKeyDown;

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

            flagToggleList.DoubleClick += (sender, args) => {
                if (flagToggleList.SelectedItems.Count > 0) {
                    flagToggleList.SelectedItems[0].BeginEdit();
                }
            };
        }
        
        private void FlagToggleOnKeyDown(object sender, KeyEventArgs e) {
            var hotkey = ResolveHotkey(e);
            if (hotkey.Invalid) return;
            if (hotkey.Clear) {
                flagToggle.Text = "";
                metroLabel9.Focus();
                return;
            }

            flagToggle.Text = hotkey.HotkeyString;

            if (_flagToggle.Id > 0) {
                HotKeyManager.UnregisterHotKey(_flagToggle.Id);
            }

            _flagToggle = hotkey;
            _flagToggle.Name = "FlagToggle";
            _flagToggle.Id = HotKeyManager.RegisterHotKey(hotkey.Key, hotkey.Modifiers);
            metroLabel9.Focus();
            SaveHotkeys();
        }

        private void HotkeyQuitOnKeyDown(object sender, KeyEventArgs e) {
            const string hkName = "ForceQuit";
            var hotkey = ResolveHotkeyNew(e, hkName);
            if (hotkey.Invalid) return;

            hotkeyQuit.Text = hotkey.HotkeyString;

            ReplaceHotkey(hkName, hotkey);
            metroLabel9.Focus();
        }

        private Hotkey ResolveHotkeyNew(KeyEventArgs e, string name) {
            var converter = new KeysConverter();
            var keyString = converter.ConvertToString(e.KeyCode);

            switch (e.KeyCode) {
                case Keys.Escape:
                    return new Hotkey {
                        HotkeyString = "Not Set",
                        Name = name,
                        Unset = true
                    };
                // Ignore modifier only
                case Keys.Shift:
                case Keys.ShiftKey:
                case Keys.Control:
                case Keys.ControlKey:
                case Keys.Alt:
                case Keys.Menu:
                case Keys.LWin:
                case Keys.RWin:
                case Keys.LMenu:
                case Keys.RMenu:
                    return new Hotkey { Invalid = true };
            }

            if (e.Modifiers != Keys.None) {
                keyString = $"{e.Modifiers}+{keyString}";
            }
            
            return new Hotkey() {
                Key = e.KeyCode,
                Modifiers = e.Modifiers,
                HotkeyString = keyString,
                Name = name
            };
        }

        private void HotkeyLoadSaveOnKeyDown(object sender, KeyEventArgs e) {
            const string hkName = "LoadSave";
            var hotkey = ResolveHotkeyNew(e, hkName);
            if (hotkey.Invalid) return;

            hotkeyLoadSave.Text = hotkey.HotkeyString;

            ReplaceHotkey(hkName, hotkey);
            metroLabel9.Focus();
        }

        private void HotkeyLoadQuickOnKeyDown(object sender, KeyEventArgs e) {
            const string hkName = "LoadLastQuickSave";
            var hotkey = ResolveHotkeyNew(e, hkName);
            if (hotkey.Invalid) return;

            hotkeyLoadQuick.Text = hotkey.HotkeyString;

            ReplaceHotkey(hkName, hotkey);
            metroLabel9.Focus();
        }

        private void HotkeyBackupSaveOnKeyDown(object sender, KeyEventArgs e) {
            const string hkName = "BackupSave";
            var hotkey = ResolveHotkeyNew(e, hkName);
            if (hotkey.Invalid) return;

            hotkeyBackupSave.Text = hotkey.HotkeyString;

            ReplaceHotkey(hkName, hotkey);
            metroLabel9.Focus();
        }

        private void SaveHotkeys() {
            File.WriteAllText($"{Utils.DataDir()}/hotkeys.json", JsonConvert.SerializeObject(new[] {
                _saveCurrentCoordinates,
                _teleportToCoordinates,
                _backupSave,
                _loadSave,
                _loadQuick,
                _forceQuit,
                _flagToggle
            }));
        }

        private void SaveHotkeys2() {
            File.WriteAllText($"{Utils.DataDir()}/hotkeysv2.json", JsonConvert.SerializeObject(_hotkeys));
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

            if (e.Key == _flagToggle.Key && e.Modifiers == _flagToggle.Modifiers) {
                FlagToggle();
                return;
            }
        }

        private void FlagToggle() {
            foreach (var item in flagToggleList.Items) {
                Diag.WriteLine(item.ToString());
            }
        }

        // flagToggle _flagToggle FlagToggle

        private void ForceQuit() {
            var rp = RemoteProc.Instance();
            if (rp == null) return;

            rp.Write(Defs.PointerByName("QuitToTitle").GetAddress(rp), (byte)1);
        }

        private void HotkeySaveCurrentCoordinatesOnKeyDown(object sender, KeyEventArgs e) {
            const string hkName = "SaveCurrentCoordinates";
            var hotkey = ResolveHotkeyNew(e, hkName);
            if (hotkey.Invalid) return;

            hotkeySaveCurrentCoordinates.Text = hotkey.HotkeyString;

            ReplaceHotkey(hkName, hotkey);
            metroLabel9.Focus();
        }

        private void HotkeyTeleportToCoordinatesOnKeyDown(object sender, KeyEventArgs e) {
            const string hkName = "TeleportToCoordinates";
            var hotkey = ResolveHotkeyNew(e, hkName);
            if (hotkey.Invalid) return;

            hotkeyTeleportToCoordinates.Text = hotkey.HotkeyString;

            ReplaceHotkey(hkName, hotkey);
            metroLabel9.Focus();
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

        private void BtnAddFlagToggle_Click(object sender, EventArgs e) {
            flagToggleList.Items.Add("Flag Name");
        }

        private void BtnRemoveFlagToggle_Click(object sender, EventArgs e) {
            if (flagToggleList.SelectedItems.Count > 0) {
                foreach (var selectedItem in flagToggleList.SelectedItems) {     
                    flagToggleList.Items.Remove((ListViewItem)selectedItem);
                }
            }
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
