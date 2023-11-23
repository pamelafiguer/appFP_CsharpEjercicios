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
    public partial class _07 : Form
    {
        public _07()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Base = int.Parse(txtBase.Text);
            int Altura = int.Parse(txtAltura.Text);

            int Area = Base * Altura;
            double Perimetro = 2 * (Base + Altura);

            txtArea.Text = Area.ToString("##.0");
            txtPerimetro.Text = Perimetro.ToString("##.0");


        }
    }
}
