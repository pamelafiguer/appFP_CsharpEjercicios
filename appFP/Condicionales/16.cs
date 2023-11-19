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
    public partial class _16 : Form
    {
        public _16()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Casa = int.Parse(txtCosto.Text);
            int Ingreso = int.Parse(txtIngreso.Text);

            double CInicial = (Ingreso < 1250 ? 0.15 * Casa : 0.30 * Casa);
            double CMensual = (Ingreso < 1250 ? (Casa - CInicial) / 120 : (Casa - CInicial) / 75);

            txtInicial.Text = CInicial.ToString("##.00");
            txtMensual.Text = CMensual.ToString("##.00");



        }
    }
}
