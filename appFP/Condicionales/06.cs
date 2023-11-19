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
    public partial class _06 : Form
    {
        public _06()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Edad1 = int.Parse(txtE1.Text);
            int Edad2 = int.Parse(txtE2.Text);
            int Edad3 = int.Parse(txtE3.Text);

            double Mayor = Edad1;
            if (Edad1 == Edad2 || Edad1 == Edad3 || Edad2 == Edad3) ;
            if (Edad2 > Mayor) Mayor = Edad2;
            if (Edad3 > Mayor) Mayor = Edad3;

            double Menor = Edad1;
            if (Edad1 == Edad2 || Edad1 == Edad3 || Edad2 == Edad3) ;
            if (Edad2 < Menor) Menor = Edad2;
            if (Edad3 < Menor) Menor = Edad3;

            txtMayor.Text = Mayor.ToString("##");
            txtMenor.Text = Menor.ToString("##");

        }
    }
}
