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
    public partial class _33 : Form
    {
        public _33()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Minutos = int.Parse(txtMin.Text);
            int Observacion = int.Parse(txtObs.Text);

            int Puntaje = 0;
            if (Minutos == 0) Puntaje = 10;
            else if (Minutos <= 2) Puntaje = 8;
            else if (Minutos <= 5) Puntaje = 6;
            else if (Minutos <= 9) Puntaje = 4;
            else Puntaje = 0;

            int Puntajeobs = 0;
            Puntajeobs = Observacion == 0 ? 10 : Observacion == 1 ? 8 : Observacion == 2 ? 5 : Observacion == 3 ? 1 : 0;

            int Total = Puntajeobs + Puntaje;

            double Bonificacion = 0;
            Bonificacion = Total < 11 ? 2.5 * Total : Total <= 13 ? 5 * Total : Total <= 19 ? 10 * Total : 12.5 * Total;

            txtPuntual.Text = Puntaje.ToString("##");
            txtPObs.Text = Puntajeobs.ToString("##");
            txtBono.Text = Bonificacion.ToString("##.00");
            txtTotal.Text = Total.ToString("##");


        }
    }
}
