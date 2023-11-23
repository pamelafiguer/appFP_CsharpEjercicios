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
    public partial class _11 : Form
    {
        public _11()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero1 = int.Parse(txtNumero1.Text);
            int Numero2 = int.Parse(txtNumero2.Text);

            int C1N1 = Numero1 / 100;
            int C2N1 = (Numero1 % 100) / 10;
            int C3N1 = Numero1 % 10;

            int C1N2 = Numero2 / 100;
            int C2N2 = (Numero2 % 100) / 10;
            int C3N2 = Numero2 % 10;

            int Intercambio1 = (C3N2 * 100) + (C2N1 * 10) + C1N2;
            int Intercambio2 = (C3N1 * 100) + (C2N2 * 10) + C1N1;

            txtInter1.Text = Intercambio1.ToString("##");
            txtInter2.Text = Intercambio2.ToString("##");






        }
    }
}
