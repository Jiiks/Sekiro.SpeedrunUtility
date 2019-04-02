using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using MemoryLibrary;
using MetroFramework;
using SekiroSpeedrunUtil.globalevents;
using SekiroSpeedrunUtil.structs;

namespace SekiroSpeedrunUtil.ui
{
    public partial class FormMain {

        public GlobalEvent GameState;
        public GlobalEvent PlayerPos;
        public GlobalEvent IngameTime;
        public GlobalEvent PlayerStats;
        public GlobalEvent LastIdol;

        private static RemoteProcess _globalRemoteProcess;

        public static RemoteProcess GlobalRemoteProc() {
            return _globalRemoteProcess; }

        private void InitLogic() {
            _globalRemoteProcess = new RemoteProcess(Utils.Sekiro());
            SetStatus("Loading definitions", Color.OrangeRed);
            LoadDefs();
            SetStatus("Waiting for Sekiro", Color.OrangeRed);
            StartProcessThread();
        }

        private void Init() {
            Diag.WriteLine("Initializing");
            SetStatus("Initializing", Color.OrangeRed);
            InitHotkeys();

            foreach (var flag in Defs.Flags.FastReverse()) {
                flag.RenderFlag(this);
            }

            GameState = new GameState();
            GameState.Subscribe((sender, e) => {
                var value = e.Value;
                if (value.GetType() != typeof(byte)) return;
                var b = (byte) value;

                UpdateCtrl(lblLoading, () => {
                    if (b == 1) {
                        lblLoading.Text = "Loading: no";
                    } else if (b == 0) {
                        lblLoading.Text = "Loading: yes";
                    } else {
                        lblLoading.Text = "Loading: unknown";
                    }
                });

            });
            GameState.Start();

            PlayerPos = new PlayerPos();
            PlayerPos.Subscribe((sender, e) => {
                var pos = (Vector3) e.Value;
                UpdateCtrl(lblPosX, () => lblPosX.Text = $"X: {pos.X}");
                UpdateCtrl(lblPosY, () => lblPosY.Text = $"Y: {pos.Y}");
                UpdateCtrl(lblPosZ, () => lblPosZ.Text = $"Z: {pos.Z}");
            });
            PlayerPos.Start();

            IngameTime = new IngameTime();
            IngameTime.Subscribe((sender, e) => {
                UpdateCtrl(lblIgt, () => lblIgt.Text = $"IGT: {(string)e.Value}");
            });
            IngameTime.Start();

            PlayerStats = new PlayerStats();
            PlayerStats.Subscribe((sender, e) => {
                var player = (Player)e.Value;
                UpdateCtrl(lblHealth, () => lblHealth.Text = $"Health: {player.CurrentHealth}/{player.MaximumHealth}");
                UpdateCtrl(lblPosture, () => lblPosture.Text = $"Posture: {player.CurrentPosture}/{player.MaximumPosture}");
            });
            PlayerStats.Start();

            LastIdol = new LastIdol();
            LastIdol.Subscribe((sender, e) => {
                var idola = (Idol)e.Value;
                UpdateCtrl(cboxLastIdol, () => cboxLastIdol.SelectedItem = idola.Name);
            });
            LastIdol.Start();

            var remoteProc = RemoteProc.Instance();
            if (remoteProc == null) {
                MetroMessageBox.Show(this, "Sekiro should be running but was not found..", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lastIdol = remoteProc.Read<int>(Defs.PointerByName("LastCommutedIdol").GetAddress(remoteProc));
            var idol = Defs.IdolById(lastIdol);
            if (idol == null) {
                Diag.WriteLine($"Null Idol? {lastIdol}");
            } else {
                UpdateCtrl(cboxLastIdol, () => {
                    cboxLastIdol.SelectedItem = idol.Name;
                });
            }

            SetStatus("Ready", Color.LimeGreen);
            Enable();
        }

        private void LoadDefs() {
            Defs.LoadDefs();
            var currentArea = string.Empty;
            foreach (var area in Defs.Areas) {
                cboxAreaTeleport.Items.Add(area.Name);
            }

            foreach (var boss in Defs.Bosses) {
                var area = boss.Areaname.Area();
                if (area == null) continue;
                if (currentArea != boss.Areaname) {
                    currentArea = boss.Areaname;
                    cboxBossTeleport.Items.Add("-" + boss.Areaname);
                }
                boss.Area = area;

                cboxBossTeleport.Items.Add(boss.Name);
            }

            currentArea = string.Empty;
            foreach (var idol in Defs.Idols) {
                var area = idol.Areaname.Area();
                if (area == null) continue;
                if (currentArea != idol.Areaname) {
                    currentArea = idol.Areaname;
                    cboxIdolTeleport.Items.Add("-" + idol.Areaname);
                }
                idol.Area = area;

                cboxIdolTeleport.Items.Add(idol.Name);
            }
        }

        private bool _sekiroHooked = false;
        private void StartProcessThread() {
            var pt = new Thread(() => {
                while (true) {
                    Thread.Sleep(100);
                    if (_sekiroHooked && Utils.Sekiro() == null) {
                        _sekiroHooked = false;
                        //TODO Reset
                        SetStatus("Waiting for Sekiro", Color.OrangeRed);
                        continue;
                    }

                    if (Utils.Sekiro() == null) {
                        SetStatus("Waiting for Sekiro", Color.OrangeRed);
                        continue;
                    }

                    if (_sekiroHooked) continue;

                    _sekiroHooked = true;
                    Init();
                    break;
                }
            }) { IsBackground = true };
            pt.Start();
        }

    }
}
