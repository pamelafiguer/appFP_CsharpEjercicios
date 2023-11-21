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
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Kilometros = int.Parse(txtKm.Text);
            int Pies = int.Parse(txtPies.Text);
            int Millas = int.Parse(txtMillas.Text);

            int Primero = Kilometros * 1000;
            double Segundo = Pies / 3.2808;
            double Tercero = Millas * 1609;

            double Metros = (Primero + Segundo + Tercero) / 100;
            double Yardas = (Metros * 3.2808) / 3;

            txtMetros.Text = Metros.ToString("##.00");
            txtYardas.Text = Yardas.ToString("##.00");



        }
    }
}
