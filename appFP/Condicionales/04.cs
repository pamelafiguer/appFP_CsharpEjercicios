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
    public partial class _04 : Form
    {
        public _04()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Practica1 = int.Parse(txtPractica1.Text);
            int Practica2 = int.Parse(txtPractica2.Text);
            int Practica3 = int.Parse(txtPractica3.Text);

            double Incremento = Practica3 > 10 ? Practica3 + 2 : Practica3 + 0;
            double Promedio = (Practica1 + Practica2 + Incremento) / 3;

            txtPromedio.Text = Promedio.ToString("##.00");



        }

       
    }
}
