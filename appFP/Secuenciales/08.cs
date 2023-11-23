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
    public partial class _08 : Form
    {
        public _08()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Radio = int.Parse(txtRadio.Text);
            int Altura = int.Parse(txtAltura.Text);

            double AreaBase = Math.Pow(Radio, 2);
            double AreaL = 2 * Math.PI * Radio * Altura;
            double AreaTotal = 2 * AreaBase * AreaL;

            txtABase.Text = AreaBase.ToString("##.00");
            txtAreaL.Text = AreaL.ToString("##.00");
            txtAreaT.Text = AreaTotal.ToString("##.00");

        }
    }
}
