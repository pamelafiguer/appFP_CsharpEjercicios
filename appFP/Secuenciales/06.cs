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
    public partial class _06 : Form
    {
        public _06()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Radio = int.Parse(txtRadio.Text);
            int Altura = int.Parse(txtAltura.Text);

            double Areatotal = 2 * Math.PI * Radio * (Radio + Altura);
            double Volumen = Math.PI * Math.Pow(Radio, 2) * Altura;

            txtAreaTotal.Text = Areatotal.ToString("##.00") + " m" ;
            txtVolumen.Text = Volumen.ToString("##.00") +  " m/3";


        }
    }
}
