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
    public partial class _21 : Form
    {
        public _21()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);

            double C1 = Numero / 1000;
            double C2yC3 = (Numero % 1000) / 10;
            double C4 = Numero % 10;

            txtCivil.Text =( C1 == 1 ? "Soltero" : C1 == 2 ? "Casado" : C1 == 3 ? "Divorciado" : C1 == 4 ? "Viudo" : "Desconocido").ToString();
            txtGenero.Text = (C4 == 1 ? "Masculino" : C4 == 2 ? "Femenino" : "Indeterminado").ToString();
            txtEdad.Text = C2yC3.ToString("##");


        }
    }
}
