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
    public partial class _22 : Form
    {
        public _22()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int UnidadesA = int.Parse(txtCA.Text);
            int UnidadesB = int.Parse(txtCB.Text);

            double ImporteA = UnidadesA * 25;
            double ImporteB = UnidadesB * 30;

            double DescA = 0;
            double DescB = 0;

            if (UnidadesA > 50) DescA = ImporteA * 0.15; else DescA = 0;
            if (UnidadesB > 60) DescB = ImporteB * 0.10; else DescB = 0;

            double Total = ImporteA + ImporteB - DescA - DescB;

            txtImporteA.Text = ImporteA.ToString("##.00");
            txtImporteB.Text = ImporteB.ToString("##.00");
            txtDescuentoA.Text = DescA.ToString("##.00");
            txtDescuentoB.Text = DescB.ToString("##.00");
            txtTotal.Text = Total.ToString("##.00");

        }
    }
}
