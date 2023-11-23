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
    public partial class _14 : Form
    {
        public _14()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int N1 = int.Parse(txtN1.Text);
            int N2 = int.Parse(txtN2.Text);
            int N3 = int.Parse(txtN3.Text);
            int N4 = int.Parse(txtN4.Text);
            int N5 = int.Parse(txtN5.Text);

            int[] Numero = { N1, N2, N3, N4, N5 };
            Array.Sort(Numero);

            int Suma = 0;
            for (int i = 2; i < 5; i++) Suma += Numero[i];

            double Promedio = Suma / 3.00;

            txtPromedio.Text = Promedio.ToString("##.00");
        }
    }
}
