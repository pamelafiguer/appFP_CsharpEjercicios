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
    public partial class _15 : Form
    {
        public _15()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Juan = int.Parse(txtJuan.Text);
            int Rosa = int.Parse(txtRosa.Text);
            int Daniel = int.Parse(txtDaniel.Text);

            double Capital = Juan + Rosa + Daniel;

            double PorcentajeJ = (Juan * 100) / Capital;
            double PorcentajeR = (Rosa * 100) / Capital;
            double PorcentajeD = ((Daniel * 100) / 3) / Capital;

            txtPorcentajeJ.Text = PorcentajeJ.ToString("##.00");
            txtPorcentajeR.Text = PorcentajeR.ToString("##.00");
            txtPorcentajeD.Text = PorcentajeD.ToString("##.00");
            txtCapital.Text = Capital.ToString("##.00");





        }
    }
}
