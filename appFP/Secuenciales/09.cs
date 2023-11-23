using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace appFP.Secuenciales
{
    public partial class _09 : Form
    {
        public _09()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);

            int C1 = Numero / 1000;
            int C2 = ((Numero % 1000) / 100);
            int C3 = (((Numero % 1000) % 100) / 10);
            int C4 = Numero % 10;

            double Suma = C1 + C2 + C3 + C4;

            txtSuma.Text = Suma.ToString("##");

        }
    }
}
