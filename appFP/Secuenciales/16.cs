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
    public partial class _16 : Form
    {
        public _16()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Horas = int.Parse(txtHoras.Text);
            int Tarifa = int.Parse(txtTarifa.Text);

            int Sueldo = Tarifa * Horas;
            double Bono = Sueldo * 0.2;
            double Bruto = Sueldo + Bono;
            double Descuento = Bruto * 0.1;
            double Neto = Bruto - Descuento;

            txtBasico.Text = Sueldo.ToString("##.00");
            txtSbruto.Text = Bruto.ToString("##.00");
            txtSueldoN.Text = Neto.ToString("##.00");




        }
    }
}
