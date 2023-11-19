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
    public partial class _17 : Form
    {
        public _17()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Docenas = int.Parse(txtDocenas.Text);
            int Precio = int.Parse(txtPrecio.Text);

            int Monto = Docenas * Precio;

            double Descuento = (Docenas >= 6 ? 0.15 * Monto : 0.10 * Monto);
            double Lapicero = (Docenas >= 30 ? (Docenas / 3) * 2 : 0);

            txtMonto.Text = Monto.ToString("##.00");
            txtDescuento.Text = Descuento.ToString("##.00");
            txtLapicero.Text = Lapicero.ToString("##.00");
            txtTotal.Text = (Monto - Descuento).ToString("##");
        }
    }
}
