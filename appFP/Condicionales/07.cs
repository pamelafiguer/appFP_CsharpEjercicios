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
    public partial class _07 : Form
    {
        public _07()
        {
            InitializeComponent();
        }

        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero1 = int.Parse(txtN1.Text);
            int Numero2 = int.Parse(txtN2.Text);
            int Numero3 = int.Parse(txtN3.Text);

            double Intermedio;
            if ((Numero1 - Numero2) * (Numero1 - Numero3) <= 0) Intermedio = Numero1;
            else if ((Numero2 - Numero1) * (Numero2 - Numero3) <= 0) Intermedio = Numero2;
            else Intermedio = Numero3;

            txtIntermedio.Text = Intermedio.ToString("##");



        }
    }
}
