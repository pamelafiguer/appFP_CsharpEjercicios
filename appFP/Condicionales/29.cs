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
    public partial class _29 : Form
    {
        public _29()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Horas = int.Parse(txtHoras.Text);

            double Tarifa = 1025
                ;
            double Bruto;
            double Extras = Horas - 48;

            if (Horas <= 48)
                Bruto = Horas * Tarifa;
            else
                Bruto = (48 * Tarifa) + (Extras * Tarifa * 0.2);
            double Descuento;
            if (Bruto > 1500) Descuento = 0.11 * Bruto; else Descuento = 0;

            txtPago.Text = (Tarifa / Horas).ToString("##.00");
            txtBruto.Text = Bruto.ToString("##.00");
            txtDescuento.Text = Descuento.ToString("##.00");
            txtTotal.Text = (Bruto - Descuento).ToString("##.00");



               

        }
    }
}
