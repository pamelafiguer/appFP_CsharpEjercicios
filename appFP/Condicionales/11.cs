using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP.Condicionales
{
    public partial class _11 : Form
    {
        public _11()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);

            String Signo = Numero > 0 ? "Positivo" : Numero < 0 ? "Negativo" : "Cero";

            txtSigno.Text = Signo.ToString();

        }
    }
}
