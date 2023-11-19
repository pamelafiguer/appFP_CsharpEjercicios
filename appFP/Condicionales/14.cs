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
    public partial class _14 : Form
    {
        public _14()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);
            int Importe = int.Parse(txtMonto.Text);

            double Descuento;
            if (Numero % 2 == 0 && Numero <= 100) Descuento = Importe * 0.15;
            else Descuento = Importe * 0.05;

            double Total = Importe - Descuento;

            txtDescuento.Text = Descuento.ToString("##.00");
            txtTotal.Text = Total.ToString("##.00");


        }
    }
}
