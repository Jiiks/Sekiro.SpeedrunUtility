using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using MetroFramework.Forms;
using Microsoft.VisualBasic;
using SekiroSpeedrunUtil.globalevents;

namespace SekiroSpeedrunUtil.ui {
    public partial class SaveManager : MetroForm {

        private FileSystemWatcher _watcher;

        public SaveManager() {
            InitializeComponent();
            listBox1.Items.Clear();
            if (!Directory.Exists(SrUtilDir())) Directory.CreateDirectory(SrUtilDir());
            foreach (var file in Directory.GetFiles(SrUtilDir())) {
                var fi = new FileInfo(file);
                listBox1.Items.Add(fi.Name);
            }

            //_watcher = new FileSystemWatcher(SekiroDir()) {EnableRaisingEvents = true};

            Closing += (sender, args) => {
                GlobalEvents.Unsubscribe("GameState", Handler);
                //_watcher.EnableRaisingEvents = false;
                //_watcher.Changed -= WatcherOnChanged;
                //_watcher.Dispose();
            };

            
        }

        private bool _selfWrite;
        private void Handler(object sender, GlobalEventArgs e) {
            var value = e.Value;
            if (value.GetType() != typeof(byte)) return;
            var b = (byte)value;
            if (b == 0) {
                if (_selfWrite) return;
                _selfWrite = true;

                listBox1.InvokeIfRequired(() => {
                    if (listBox1.SelectedItems.Count <= 0) return;
                    var fileName = $"{SrUtilDir()}/{listBox1.SelectedItems[0].Text}";
                    if (!File.Exists(fileName)) {
                        Debug.WriteLine($"[Pseudo Readonly] File does not exist {fileName}");
                        return;
                    }
                    Debug.WriteLine($"[Pseudo Readonly] Restoring {fileName}");
                    File.Copy(fileName, $"{SekiroDir()}/S0000.sl2", true);
                });
            } else {
                _selfWrite = false;
            }
        }

        
        private void WatcherOnChanged(object sender, FileSystemEventArgs e) {
            listBox1.InvokeIfRequired(() => {
                if (_selfWrite) return;
                if (listBox1.SelectedItems.Count <= 0) return;
                var fileName = $"{SrUtilDir()}/{listBox1.SelectedItems[0].Text}";
                if (!File.Exists(fileName)) {
                    Debug.WriteLine($"[Pseudo Readonly] File does not exist {fileName}");
                    return;
                }

                _selfWrite = true;
                Thread.Sleep(2000);
                Debug.WriteLine($"[Pseudo Readonly] Restoring {fileName}");
                File.Copy(fileName, $"{SekiroDir()}/S0000.sl2", true);
                _selfWrite = false;
            });

        }

        private void BtnSave_Click(object sender, EventArgs e) {
            if (!Directory.Exists(SrUtilDir())) Directory.CreateDirectory(SrUtilDir());
            var saveDir = SekiroDir();
            if (saveDir == string.Empty) return;
            var saveFile = $"{saveDir}/S0000.sl2";
            if (!File.Exists(saveFile)) return;

            var fileName = Interaction.InputBox("Name", "Name", "S0000", -1, -1);
            if (fileName == string.Empty) return;
            var destPath = $"{SrUtilDir()}/{fileName}";

            var iter = 1;
            while (File.Exists(destPath)) {
                destPath = $"{SrUtilDir()}/{fileName}_{iter}";
                iter++;
            }

            File.Copy(saveFile, destPath);
            listBox1.Items.Clear();
            foreach (var file in Directory.GetFiles(SrUtilDir())) {
                var fi = new FileInfo(file);
                listBox1.Items.Add(fi.Name);
            }
        }

        private string SekiroDir() {
            var appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dirs = Directory.GetDirectories($"{appdataPath}/Sekiro");

            foreach (var dir in dirs) {
                if (dir.Contains("srutil")) continue;
                if (!File.Exists($"{dir}/S0000.sl2")) continue;
                return dir;
            }

            return string.Empty;
        }

        private string SrUtilDir() {
            var appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return $"{appdataPath}/Sekiro/srutil";
        }

        private void BtnLoad_Click(object sender, EventArgs e) {
            var sekiroDir = SekiroDir();
            if (sekiroDir == string.Empty) return;
            var fileName = listBox1.SelectedItems[0].Text;
            if (!File.Exists($"{SrUtilDir()}/{fileName}")) {
                Debug.WriteLine($"File does not exist: {SrUtilDir()}/{fileName}");
                return;
            }
            File.Copy($"{SrUtilDir()}/{fileName}", $"{sekiroDir}/S0000.sl2", true);
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            var fileName = listBox1.SelectedItems[0].ToString();
            if (!File.Exists($"{SrUtilDir()}/{fileName}")) return;

            File.Delete($"{SrUtilDir()}/{fileName}");

            listBox1.Items.Clear();
            foreach (var file in Directory.GetFiles(SrUtilDir())) {
                var fi = new FileInfo(file);
                listBox1.Items.Add(fi.Name);
            }
        }

        private void CbReadonly_CheckedChanged(object sender, EventArgs e) {
            if (cbReadonly.Checked) {
                GlobalEvents.Subscribe("GameState", Handler);
            } else {
                GlobalEvents.Unsubscribe("GameState", Handler);
            }
            /*
            if (cbReadonly.Checked) {
                _watcher.EnableRaisingEvents = true;
                _watcher.Changed += WatcherOnChanged;
                return;
            }
            _watcher.EnableRaisingEvents = false;
            _watcher.Changed -= WatcherOnChanged;
            _watcher.Dispose();
            */
        }
    }
}
