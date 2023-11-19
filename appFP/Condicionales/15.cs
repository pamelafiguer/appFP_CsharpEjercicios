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
    public partial class _15 : Form
    {
        public _15()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int MontoV = int.Parse(txtMonto.Text);
            int Categoria = int.Parse(txtCategoria.Text);

            double Comision = (MontoV <= 5000 ? 0.05 : MontoV <= 10000 ? 0.08 : MontoV <= 20000 ? 0.10 : 0.15);
            double Bonificacion = (Categoria == 1 ? 0.05 : Categoria == 2 ? 0.10 : Categoria == 3 ? 0.12 : 0.16);
            double Sueldo = 1025 + (Comision * MontoV);
            double Bruto = Sueldo + (Sueldo * Bonificacion);

            double Descuento;
            if (Bruto >= 3500) Descuento = 0.15 * Bruto;
            else Descuento = 0.08 * Bruto;

            double Neto = Bruto - Descuento;

            txtBruto.Text = Bruto.ToString("##.00");
            txtDescuento.Text = Descuento.ToString("##.00");
            txtNeto.Text = Neto.ToString("##.00");
            txtComision.Text = (Comision * MontoV).ToString("##.00");


        }
    }
}
