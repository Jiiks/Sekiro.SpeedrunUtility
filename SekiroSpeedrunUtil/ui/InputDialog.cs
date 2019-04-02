using System.Windows.Forms;
using MetroFramework.Forms;

namespace SekiroSpeedrunUtil.ui {
    public partial class InputDialog : MetroForm {

        public string Value;
        public DialogResult Result = DialogResult.Abort;

        public InputDialog(string title, string defaultValue, string okText = "OK") {
            InitializeComponent();
            Text = title;
            btnOk.Text = okText;
            metroTextBox1.Text = defaultValue;
            metroTextBox1.KeyDown += (sender, e) => {
                if(e.KeyCode == Keys.Enter) btnOk.PerformClick();
            };
        }

        private void BtnOk_Click(object sender, System.EventArgs e) {
            Value = metroTextBox1.Text;
            Result = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, System.EventArgs e) {
            Result = DialogResult.Cancel;
            Close();
        }
    }
}
