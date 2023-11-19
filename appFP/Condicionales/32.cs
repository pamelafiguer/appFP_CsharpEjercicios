using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP.Condicionales
{
    public partial class _32 : Form
    {
        public _32()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Promedio = int.Parse(txtPromedio.Text);
            string Categoria = txtCategoria.Text;

            int Pension = 0;
            Pension = "A".Equals(Categoria) ? 550 : "B".Equals(Categoria) ? 500 : "C".Equals(Categoria) ? 450 : "D".Equals(Categoria) ? 400 : 0;
            double Descuento = 0;
            Descuento = Promedio <= 14 ? 0 : Promedio <= 16 ? Pension * 0.10 : Promedio <= 18 ? Pension * 0.12 : Pension * 0.15; ;

            txtActual.Text = Pension.ToString("##.00");
            txtDescuento.Text = Descuento.ToString("##.00");
            txtNueva.Text = (Pension - Descuento).ToString("##.00");


        }
    }
}
