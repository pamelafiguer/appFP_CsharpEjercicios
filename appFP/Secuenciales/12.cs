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
    public partial class _12 : Form
    {
        public _12()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int A = int.Parse(txtA.Text);
            int B = int.Parse(txtB.Text);
            int C = int.Parse(txtC.Text);

            double Determinante = Math.Pow(B, 2) - (4 * A * C);
            if (Determinante > 0) ;
            double x1 = ((B * (-1)) + Math.Sqrt(Determinante)) / (2 * A);
            double x2 = ((B * (-1)) - Math.Sqrt(Determinante)) / (2 * A);

            txtX1.Text = x1.ToString("##");
            txtX2.Text = x2.ToString("##");

        }
    }
}
