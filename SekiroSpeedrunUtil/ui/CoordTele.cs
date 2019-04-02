using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SekiroSpeedrunUtil.ui
{
    public partial class CoordTele : Form
    {
        public CoordTele(float x, float y, float z) {
            InitializeComponent();

            coordX.Text = x.ToString();
            coordY.Text = y.ToString();
            coordZ.Text = z.ToString();
        }

        private void BtnTeleport_Click(object sender, EventArgs e) {

        }
    }
}
