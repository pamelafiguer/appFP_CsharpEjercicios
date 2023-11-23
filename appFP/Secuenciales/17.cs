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
    public partial class _17 : Form
    {
        public _17()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Donacion = int.Parse(txtDonacion.Text);

            double Comedor = Donacion * 0.35;
            double Salud = Donacion * 0.25;
            double Escuela = Donacion * 0.25;
            double Asilo = Donacion * 0.15;

            txtComedor.Text = Comedor.ToString("##.00");
            txtSalud.Text = Salud.ToString("##.00");
            txtEscuela.Text = Escuela.ToString("##.00");
            txtAsilo.Text = Asilo.ToString("##.00");


        }
    }
}
