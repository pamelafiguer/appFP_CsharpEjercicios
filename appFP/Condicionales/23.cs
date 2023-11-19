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
    public partial class _23 : Form
    {
        public _23()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Matematica = int.Parse(txtMatematica.Text);
            int Fisica = int.Parse(txtFisica.Text);

            double Propina = Matematica + Fisica * 0.50;
            if (Matematica > 17) Propina += (Matematica - 17) * 2;
            if (Fisica > 15) Propina += (Fisica - 15) * 2;

            txtPropina.Text = Propina.ToString("##.00");
            txtPromedio.Text = ((Matematica + Fisica) / 2).ToString("##.00");
            txtReloj.Text = ((Matematica + Fisica) / 2 > 16 ? "Si" : "No").ToString();

        }
    }
}
