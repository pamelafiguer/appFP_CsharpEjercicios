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
    public partial class _18 : Form
    {
        public _18()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Cantidad = int.Parse(txtUnidades.Text);
            int Precio = int.Parse(txtPrecio.Text);

            int Importe = Precio * Cantidad;
            double Descuento = Importe - (Importe * 0.15);
            double Total = Descuento - (Descuento * 0.15);

            txtImporte.Text = Importe.ToString("##.00");
            txtDescuento.Text = Descuento.ToString("##.00");
            txtTotal.Text = Total.ToString("##.00");

        }
    }
}
