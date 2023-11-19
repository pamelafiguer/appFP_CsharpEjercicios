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
    public partial class _34 : Form
    {
        public _34()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Peso = int.Parse(txtPeso.Text);
            double Estatura = double.Parse(txtEstatura.Text);

            double imc = Peso / (Estatura * Estatura);

            String Obesidad = "";
            Obesidad = imc < 20 ? "Delgado" : imc < 25 ? "Normal" : imc < 27 ? "Sobrepeso" : "Obesidad";

            txtimc.Text = Obesidad.ToString();


        }
    }
}
