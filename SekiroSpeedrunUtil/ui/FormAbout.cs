using System;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SekiroSpeedrunUtil.ui
{
    public partial class FormAbout : MetroForm
    {
        public FormAbout() {
            InitializeComponent();
            Text = "";
            titleLabel.Text = $"Sekiro Speedrun Utility v{Application.ProductVersion} by Jiiks";
        }

        private void MetroLink1_Click(object sender, EventArgs e) {
            Process.Start(@"https://www.gnu.org/licenses/gpl-3.0.en.html");
        }

        private void MetroLink2_Click(object sender, EventArgs e) {
            Process.Start(@"https://github.com/Jiiks/Sekiro.SpeedrunUtility");
        }
    }
}
