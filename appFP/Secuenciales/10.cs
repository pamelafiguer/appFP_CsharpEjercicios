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
    public partial class _10 : Form
    {
        public _10()
        {
            InitializeComponent();
        }

        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);

            int C1 = Numero / 1000;
            int C2 = ((Numero & 1000) / 100);
            int C3 = (((Numero % 1000) % 100) / 10);
            int C4 = Numero % 10;

            double Invertir = (C4 * 1000) + (C3 * 100) + (C2 * 10) + C1;

            txtInvertido.Text = Invertir.ToString("##");

        }
    }
}
