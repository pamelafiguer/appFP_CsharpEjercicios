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
    public partial class _26 : Form
    {
        public _26()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Monto = int.Parse(txtMonto.Text);

            double Prestamo;
            if (Monto > 5000) Prestamo = 0.30 * Monto; else Prestamo = 0.20 * Monto;

            double Interes = Prestamo * 0.10;

            txtBanco.Text = (Prestamo + Interes).ToString("##.00");
            txtEmpresa.Text = ((Monto - Prestamo - Interes)).ToString("##.00");

        }
    }
}
