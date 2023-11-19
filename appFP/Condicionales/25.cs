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
    public partial class _25 : Form
    {
        public _25()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Hijos = int.Parse(txtHijos.Text);
            int Sueldo = int.Parse(txtSueldoB.Text);

            double Bono;
            if (Hijos > 1) Bono = (0.125 * Sueldo) + 40 * Hijos;
            else Bono = (0.10 * Sueldo) + 40 * Hijos;

            txtBono.Text = Bono.ToString("##.00");
            txtTotal.Text = (Bono + Sueldo).ToString("##.00");


        }
    }
}
