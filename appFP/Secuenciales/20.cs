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
    public partial class _20 : Form
    {
        public _20()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Dinero = int.Parse(txtDinero.Text);

            double N200 = Dinero / 200;
            double N100 = (Dinero % 200) / 100;
            double N50 = ((Dinero% 200) % 100) / 50;
            double N20 = (((Dinero% 200) % 100) % 50) / 20;
            double N10 = ((((Dinero % 200) % 100) % 50) % 20) / 10;

            double M5 = (((((Dinero % 200) % 100) % 50) % 20) % 10) / 5;
            double M2 = ((((((Dinero % 200) % 100) % 50) % 20) % 10) % 5) / 2;
            double M1 = (((((((Dinero % 200) % 100) % 50) % 20) % 10) % 5) % 2) / 1;

            txt200.Text = N200.ToString("##");
            txt100.Text = N100.ToString("##");
            txt50.Text = N50.ToString("##");
            txt20.Text = N20.ToString("##");
            txt10.Text = N10.ToString("##");
            txtM5.Text = M5.ToString("##");
            txtM2.Text = M2.ToString("##");
            txtM1.Text = M1.ToString("##");



        }
    }
}
