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
    public partial class _13 : Form
    {
        public _13()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);

            double C1 = Numero / 100;
            double C2 = (Numero % 100) / 10;
            double C3 = Numero % 10;

            String Tipo;
            if ((C1 == C2 - 1 && C2 == C3 - 1) || (C1 == C2 + 1 && C2 == C3 + 1)) Tipo = "Consecutivo";
            else Tipo = "No consecutivo";

            txtTipo.Text = Tipo.ToString();

        }
    }
}
