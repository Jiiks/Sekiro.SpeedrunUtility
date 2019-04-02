using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using SekiroSpeedrunUtil.globalevents;

namespace SekiroSpeedrunUtil.ui {
    public partial class FormMain {

        private string _saveDir = "SekiroSpeedrunUtil";
        private string _sekiroDir = string.Empty;
        private string _profileDir = string.Empty;

        private void SmAddProfile_Click(object sender, EventArgs e) {
            var dialog = new InputDialog("Profile Name", "profile", "Create");
            dialog.FormClosing += (o, args) => {
                if (dialog.Result != DialogResult.OK) return;
                if (dialog.Value == string.Empty) return;
                NewProfile(dialog.Value);
            };
            dialog.Show(this);
        }

        private void NewProfile(string profileName) {
            try {
                if(smProfiles.Items.Contains(profileName)) throw new Exception("Profile already exists!");

                var profileDir = $"{SaveDir()}/{profileName}";
                if(Directory.Exists(profileDir)) throw new Exception("Profile already exists!");

                smProfiles.Items.Add(profileName);

            } catch (Exception ex) {
                MetroMessageBox.Show(this,
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void SmDelProfile_Click(object sender, EventArgs e) {

        }

        private void SmSave_Click(object sender, EventArgs e) {
            if (_profileDir == string.Empty) return;

            try {
                var dialog = new InputDialog("Save Name", "S0000", "Save");
                dialog.FormClosing += (o, args) => {
                    if (dialog.Result != DialogResult.OK) return;
                    if (dialog.Value == string.Empty) return;
                    SaveGame(dialog.Value);
                };
                dialog.Show(this);
            } catch (Exception ex) {
                MetroMessageBox.Show(this,
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void SaveGame(string name) {
            try {
                var destPath = $"{ProfileDir()}/{name}";
                var iter = 1;
                while (File.Exists(destPath)) {
                    destPath = $"{ProfileDir()}/{name}_{iter}";
                    iter++;
                }

                File.Copy($"{_sekiroDir}/S0000.sl2", destPath.Replace(" ", "_"));
                SmListSaves();
            } catch (Exception ex) {
                MetroMessageBox.Show(this,
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                SmListSaves();
            }
        }

        private string _smQuickLoadLastItem = string.Empty;
        private string _smQuickLoadLastProfile = string.Empty;
        private string _smQuickLoadLastQuick = string.Empty;
        private void QuickLoad() {
            if (_smQuickLoadLastItem == string.Empty || _smQuickLoadLastProfile == string.Empty) return;
            try {
                var fPath = $"{ProfileDir(_smQuickLoadLastProfile)}/{_smQuickLoadLastItem.Replace(" ", "_")}";
                File.Copy(fPath, $"{_sekiroDir}/S0000.sl2", true);
                Toast("Quickload Success!", Color.MediumAquamarine, Color.Black);
            } catch (Exception ex) {
                MetroMessageBox.Show(this,
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void QuickLoadQuick() {
            if (_smQuickLoadLastQuick == string.Empty || _smQuickLoadLastProfile == string.Empty) return;
            try {
                var fPath = $"{ProfileDir(_smQuickLoadLastProfile)}/{_smQuickLoadLastQuick.Replace(" ", "_")}";
                File.Copy(fPath, $"{_sekiroDir}/S0000.sl2", true);
                Toast("Quickload Success!", Color.MediumAquamarine, Color.Black);
            } catch (Exception ex) {
                MetroMessageBox.Show(this,
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void QuickSave() {
            var qsName = smQuickSave.Text;
            try {
                var iter = 0;
                var destPath = $"{ProfileDir()}/{qsName.Replace("%", iter.ToString())}";
                
                while (File.Exists(destPath)) {
                    destPath = $"{ProfileDir()}/{qsName.Replace("%", iter.ToString())}";
                    iter++;
                }
                _smQuickLoadLastQuick = new FileInfo(destPath.Replace(" ", "_")).Name;
                File.Copy($"{_sekiroDir}/S0000.sl2", destPath.Replace(" ", "_"));
                SmListSaves();
                Toast("Quicksave Success!", Color.MediumAquamarine, Color.Black);
            } catch (Exception ex) {
                MetroMessageBox.Show(this,
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void SmLoad_Click(object sender, EventArgs e) {
            if (smSavesList.Items.Count <= 0 || smSavesList.SelectedItems.Count <= 0) return;
            try {
                var fPath = $"{ProfileDir()}/{smSavesList.SelectedItems[0].Text.Replace(" ", "_")}";
                File.Copy(fPath, $"{_sekiroDir}/S0000.sl2", true);
                Toast("Save Loaded!", Color.Black, Color.MediumAquamarine);
            } catch (Exception ex) {
                MetroMessageBox.Show(this,
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void SmDelete_Click(object sender, EventArgs e) {
            if (smSavesList.Items.Count <= 0 || smSavesList.SelectedItems.Count <= 0) return;
            try {
                var fPath = $"{ProfileDir()}/{smSavesList.SelectedItems[0].Text.Replace(" ", "_")}";
                File.Delete(fPath);
                SmListSaves();
            } catch (Exception ex) {
                MetroMessageBox.Show(this,
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                SmListSaves();
            }
        }

        private void SmOpenSavesDir_Click(object sender, EventArgs e) {
            Process.Start(SaveDir());
        }

        private void SmProfiles_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                _profileDir = ProfileDir();
                SmListSaves();
            } catch (Exception ex) {
                MetroMessageBox.Show(this,
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void SmListSaves() {
            smSavesList.Items.Clear();
            foreach (var file in Directory.GetFiles(_profileDir)) {
                smSavesList.Items.Add(new FileInfo(file).Name.Replace("_", " "));
            }
        }

        private string SaveDir() {
            var appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return $"{appdataPath}/{_saveDir}/saves";
        }

        private string ProfileDir(string name = null) {
            _smQuickLoadLastProfile = smProfiles.SelectedItem.ToString();
            var dir = name == null ? $"{SaveDir()}/{smProfiles.SelectedItem}" : $"{SaveDir()}/{name}";
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            return dir;
        }

        private string SekiroDir() {
            var appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dirs = Directory.GetDirectories($"{appdataPath}/Sekiro");

            foreach (var dir in dirs) {
                if (dir.Contains("srutil")) continue;
                if (!File.Exists($"{dir}/S0000.sl2")) continue;
                return dir;
            }

            MetroMessageBox.Show(this, 
                $@"Could not locate Sekiro save directory in {appdataPath}\Sekiro.\nMake sure you have a save file in there.", 
                "Error", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error
                );

            return string.Empty;
        }

        private void SmRename(string oldName, string newName, int index) {
            try {
                newName = newName.Replace(" ", "_");
                var destPath = $"{ProfileDir()}/{newName}";
                var iter = 1;
                while (File.Exists(destPath)) {
                    destPath = $"{ProfileDir()}/{newName}_{iter}";
                    iter++;
                }

                File.Move($"{ProfileDir()}/{oldName.Replace(" ", "_")}", destPath);
                SmListSaves();
            } catch (Exception ex) {
                
                MetroMessageBox.Show(this,
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                SmListSaves();
            }
        }

        private bool _smSelfWrite;
        private void SmPseudoReadonlyHandler(object sender, GlobalEventArgs e) {
            var value = e.Value;
            if (value.GetType() != typeof(byte)) return;
            var b = (byte)value;
            if (b == 0) {
                if (_smSelfWrite) return;
                _smSelfWrite = true;
                QuickLoad();
            } else {
                _smSelfWrite = false;
            }
        }

        private void SmPseudoReadonly_CheckedChanged(object sender, EventArgs e) {
            if (!smPseudoReadonly.Checked) {
                GameState.Unsubscribe(SmPseudoReadonlyHandler);
                return;
            }
            MetroMessageBox.Show(this, "Pseudo Read-only will restore your last selected save on any loading state.",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GameState.Subscribe(SmPseudoReadonlyHandler);
        }

        private bool _smInitialized = false;
        private void SmBecameVisible() {
            if (!_smInitialized) {
                _smInitialized = true;
                smSavesList.DoubleClick += (sender, args) => {
                    if (smSavesList.Items.Count <= 0 || smSavesList.SelectedItems.Count <= 0) return;
                    smSavesList.SelectedItems[0].BeginEdit();
                };

                smSavesList.AfterLabelEdit += (sender, args) => {
                    if (smSavesList.Items.Count <= 0 || smSavesList.SelectedItems.Count <= 0) return;
                    var oldName = smSavesList.Items[args.Item].Text;
                    var newName = args.Label;
                    SmRename(oldName, newName, args.Item);
                };

                smSavesList.SelectedIndexChanged += (sender, args) => {
                    if (smSavesList.Items.Count <= 0 || smSavesList.SelectedItems.Count <= 0) return;
                    _smQuickLoadLastItem = smSavesList.SelectedItems[0].Text;
                    
                };
            }
            if (_sekiroDir != string.Empty) return;
            _sekiroDir = SekiroDir();
            try {
                if (!Directory.Exists(SaveDir())) Directory.CreateDirectory(SaveDir());
            } catch (Exception ex) {
                MetroMessageBox.Show(this,
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (_sekiroDir == string.Empty) return;

            try {
                smProfiles.Items.Clear();
                foreach (var directory in Directory.GetDirectories(SaveDir())) {
                    smProfiles.Items.Add(new DirectoryInfo(directory).Name);
                }

                if (smProfiles.Items.Count <= 0) smProfiles.Items.Add("default");
            } catch (Exception ex) {
                MetroMessageBox.Show(this,
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }
    }
}
