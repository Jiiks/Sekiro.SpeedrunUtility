using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using SekiroSpeedrunUtil.enums;

namespace SekiroSpeedrunUtil.ui {
    public partial class FormMain : MetroFramework.Forms.MetroForm {

        private bool _stopUpdates;
        private MouseDetector _mouseDetector;
        private static FormMain _formMain;
        private GlobalHook _hook;

        public static void Debug(string msg) {
            _formMain.tbDebug.InvokeIfRequired(() => {
                _formMain.tbDebug.AppendText(msg);
                _formMain.tbDebug.AppendText(Environment.NewLine);
            });
        }

        public FormMain() {
            InitializeComponent();
            _formMain = this;
            _hook = new GlobalHook();
            _hook.OnHookEvent += (sender, e) => {
                if (!cbOverlayMode.Checked) return;
                var sekiro = Utils.Sekiro();
                if (sekiro == null) return;

                if (e.HWnd != sekiro.MainWindowHandle) return;

                this.InvokeIfRequired(() => {
                    Native.GetWindowRect(e.HWnd, out var rect);
                    Location = new Point(rect.Left, rect.Top);
                });
            };
            _hook.InitHook();

            Closing += (sender, args) => {
                _hook.UnSubscribe(HookEvent.EVENT_OBJECT_LOCATIONCHANGE);
            };

            mainTabControl.SelectedIndex = 0;

            var updaterThread = new Thread(() => {
                while (!_stopUpdates) {
                    Thread.Sleep(60 * 1000 * 15);
                    var updates = Updater.CheckForUpdates(out var latestVer);
                    if (!updates) continue;
                    _stopUpdates = true;
                    updateLink.InvokeIfRequired(() => {
                        updateLink.ForeColor = Color.LimeGreen;
                        updateLink.UseCustomForeColor = true;
                        updateLink.Text = $"[Update Available! - v{latestVer}]";
                    });
                }
            }) {IsBackground = true};

            updaterThread.Start();

            updateLink.Text = $"[v{Application.ProductVersion} - Check for Updates]";

            InitUi();
            InitLogic();
        }

        private void InitUi() {
            Disable();
            metroToolTip1.SetToolTip(btnEditSetup, "Edit setup");
            metroToolTip1.SetToolTip(btnAddSetup, "Add setup");
            metroToolTip1.SetToolTip(btnCoordTeleport, "Teleport to coordinates");
            metroToolTip1.SetToolTip(btnLoadCurrentCoords, "Load current coordinates");
            metroToolTip1.SetToolTip(btnReloadSetups, "Reload setups");
            metroToolTip1.SetToolTip(btnRemoveSetup, "Remove setup");
            metroToolTip1.SetToolTip(btnLoadSetup, "Load selected setup");
            metroToolTip1.SetToolTip(btnTeleportToCoordinates, "Teleport to coordinates");
            metroToolTip1.SetToolTip(lblPosX, "Player position");
            metroToolTip1.SetToolTip(lblPosY, "Player position");
            metroToolTip1.SetToolTip(lblPosZ, "Player position");
            metroToolTip1.SetToolTip(btnDebug, "Debug");
        }

        private void SetStatus(string status) => SetStatus(status, Color.Black);
        private void SetStatus(string status, Color color) {
            lblGlobalStatus.InvokeIfRequired(() => {
                lblGlobalStatus.ForeColor = color;
                lblGlobalStatus.Text = status;
            });
        }

        private void UpdateCtrl(ISynchronizeInvoke obj, MethodInvoker action) {
            obj.InvokeIfRequired(action);
        }

        private void Enable() {
            UpdateCtrl(mainPanel, () => mainPanel.Enabled = true);
        }

        private void Disable() {
            UpdateCtrl(mainPanel, () => mainPanel.Enabled = false);
        }

        private void FormMain_Load(object sender, EventArgs e) {
            tabSaveManager.VisibleChanged += (o, args) => {
                if (tabSaveManager.Visible) SmBecameVisible();
            };
            _mouseDetector = new MouseDetector();
        }

        private void Toast(string msg, Color background, Color foreground, SystemSound sound = null) {
            if (Height <= 100) return;
            if (cbToastSounds.Checked) {
                if (sound == null) sound = SystemSounds.Asterisk;
                sound.Play();
            }
            toastMsg.InvokeIfRequired(() => {
                toastMsg.Text = msg;
                toastMsg.ForeColor = foreground;
                toast.InvokeIfRequired(() => {
                    toast.BackColor = background;
                    toast.Show();
                    toast.SlideToDestination(430, 2, () => {
                        Thread.Sleep(3000);
                        toast.SlideToDestination(520, 2, () => {});
                    });
                });
            });
        }

        private void UpdateLink_Click(object sender, EventArgs e) {
            Process.Start(@"https://github.com/Jiiks/Sekiro.SpeedrunUtility/releases");
        }

        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            //var traceListener = new TextBoxTraceListener(tbDebug);
            //Trace.Listeners.Add(traceListener);
        }

        private FormAbout _formAbout;
        private void BtnInfo_Click(object sender, EventArgs e) {
            if (_formAbout != null) {
                _formAbout.Show(this);
                return;
            }

            _formAbout = new FormAbout();
            _formAbout.Show(this);
        }

        private void CbOverlayMode_CheckedChanged(object sender, EventArgs e) {
            if (cbOverlayMode.Checked) {
                Size = new Size(850, 25);
                lblGlobalStatus.Hide();
                updateLink.Hide();
                TopMost = true;
                _mouseDetector.MouseMove += DetectorMouseMove;
                lblTinyTitle.Show();
                Opacity = 0.3d;

                _hook.Subscribe(HookEvent.EVENT_OBJECT_LOCATIONCHANGE);

                var sekiro = Utils.Sekiro();
                if (sekiro == null) return;

                this.InvokeIfRequired(() => {
                    Native.GetWindowRect(sekiro.MainWindowHandle, out var rect);
                    Location = new Point(rect.Left, rect.Top);
                });
            }
            else {
                Size = new Size(850, 515);
                lblGlobalStatus.Show();
                updateLink.Show();
                TopMost = false;
                _mouseDetector.MouseMove -= DetectorMouseMove;
                lblTinyTitle.Hide();
                Opacity = 1d;
                _hook.UnSubscribe(HookEvent.EVENT_OBJECT_LOCATIONCHANGE);
            }
        }

        private void DetectorMouseMove(object sender, Point p) {
            var pt = PointToClient(p);
            if (ClientSize.Width >= pt.X && ClientSize.Height >= pt.Y &&  pt.X > 0 && pt.Y > 0) {
                Size = new Size(850, 515);
                lblGlobalStatus.Show();
                updateLink.Show();
                Opacity = 1d;
                lblTinyTitle.Hide();
                return;
            }
            Size = new Size(850, 25);
            lblGlobalStatus.Hide();
            updateLink.Hide();
            lblTinyTitle.Show();
            Opacity = 0.2d;
        }
    }
}
