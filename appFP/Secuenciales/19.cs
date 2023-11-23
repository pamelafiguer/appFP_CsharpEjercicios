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
    public partial class _19 : Form
    {
        public _19()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Monto = int.Parse(txtMonto.Text);

            double Comision = Monto * 0.09;
            double Bruto = 500 + Comision;
            double Descuento = Bruto * 0.11;
            double Neto = Bruto - Descuento;

            txtComision.Text = Comision.ToString("##.00");
            txtBruto.Text = Bruto.ToString("##.00");
            txtDescuento.Text = Descuento.ToString("##.00");
            txtNeto.Text = Neto.ToString("##.00");

        }
    }
}
