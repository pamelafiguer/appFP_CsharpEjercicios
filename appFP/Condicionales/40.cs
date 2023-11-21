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
    public partial class _40 : Form
    {
        public _40()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Practica1 = int.Parse(txtP1.Text);
            int Practica2 = int.Parse(txtP2.Text);
            int Practica3 = int.Parse(txtP3.Text);
            int Examenp = int.Parse(txtParcial.Text);
            int ExamenF = int.Parse(txtFinal.Text);

            double Mate = Practica1 * 0.1 + Practica2 * 0.2 + Practica3 * 0.1 + Examenp * 0.3 + ExamenF * 0.3;
            double Fisica = Practica1 * 0.2 + Practica2 * 0.2 + Practica3 * 0.2 + Examenp * 0.2 + ExamenF * 0.2;
            double Quimica = Practica1 * 0.1 + Practica2 * 0.3 + Practica3 * 0.1 + Examenp * 0.25 + ExamenF * 0.25;

            if (Mate > 13) txtMatematica.Text = "Aprobado";
            else txtMatematica.Text = "Desaprobado";

            if (Fisica > 13) txtFisica.Text = "Aprobado";
            else txtFisica.Text = "Desaprobado";

            if (Quimica > 13) txtQuimica.Text = "Aprobado";
            else txtQuimica.Text = "Desaprobado";

        }
    }
}
