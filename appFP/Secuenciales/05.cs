using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP.Secuenciales
{
    public partial class _05 : Form
    {
        public _05()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Gb = int.Parse(txtGB.Text);

            double Megabytes = Gb * 1024;
            double Kilobytes = Megabytes * 1024;
            double Bytes = Kilobytes * 1024;

            txtMB.Text = Megabytes.ToString("##.00") + " MB";
            txtKB.Text = Kilobytes.ToString("##.00") + " KB" ;
            txtBytes.Text = Bytes.ToString("##.00") + " B";

        }
    }
}
