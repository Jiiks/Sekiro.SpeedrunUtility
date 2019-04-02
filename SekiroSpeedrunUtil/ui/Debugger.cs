using System;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace SekiroSpeedrunUtil.ui {
    public partial class Debugger : MetroForm {
        public Debugger() {
            InitializeComponent();
            debugTextbox.Text = "";
            FormClosing += Closing;
        }

        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            var tbtl = new TextBoxTraceListener(debugTextbox);
            Trace.Listeners.Add(tbtl);
        }

        protected void Closing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason != CloseReason.UserClosing) return;
            e.Cancel = true;
            Hide();
        }
    }

    public class TextBoxTraceListener : TraceListener {
        private readonly MetroTextBox _tBox;

        public TextBoxTraceListener(MetroTextBox box) {
            _tBox = box;
        }

        public override void Write(string msg) {
            _tBox.Parent.Invoke(new MethodInvoker(delegate () {
                _tBox.AppendText(msg);
            }));
        }

        public override void WriteLine(string msg) {
            Write(msg + "\r\n");
        }
    }
}
