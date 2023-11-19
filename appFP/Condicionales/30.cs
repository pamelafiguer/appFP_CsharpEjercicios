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
    public partial class _30 : Form
    {
        public _30()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Dia = int.Parse(txtDia.Text);
            int Cuota = int.Parse(txtCuota.Text);

            double Descuento = 0;
            double Recargo = 0;
            if (Dia <= 10) Descuento = Math.Max(5, Cuota * 0.02);
            else if (Dia <= 20) Descuento = 0;
            else Recargo = Math.Max(10, Cuota * 0.03);

            txtDescuento.Text = Descuento.ToString("##.00");
            txtRecargo.Text = Recargo.ToString("##.00");
            txtImporte.Text = (Cuota + (Recargo - Descuento)).ToString("##.00");




        }
    }
}
