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
    public partial class _09 : Form
    {
        public _09()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Codigo = int.Parse(txtCodigo.Text);
            int Cantidad = int.Parse(txtCantidad.Text);

            double Precio;
            if (Codigo == 101) Precio = 17;
            else if (Codigo == 102) Precio = 25;
            else if (Codigo == 103) Precio = 16;
            else if (Codigo == 104) Precio = 27;
            else Precio = 0;

            double Importe = Cantidad * Precio;
            double Descuento = ((Cantidad <= 10 ? 0.05 : Cantidad <= 20 ? 0.08 : Cantidad <= 30 ? 0.10 : 0.13) * Importe);
            double Total = Importe - Descuento;

            txtDescuento.Text = Descuento.ToString("##.00");
            txtTotal.Text = Total.ToString("##.00");
            txtImporte.Text = Importe.ToString("##.00");


        }
    }
}
