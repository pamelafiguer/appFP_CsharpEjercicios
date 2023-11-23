using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP.repetitivos
{
    public partial class _07 : Form
    {
        public _07()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);

            long Factorial = 1;

            for (int i = 1; i <= Numero; i++)
                Factorial *= + i;

            txtFactorial.Text = Factorial.ToString("##");

        }
    }
}
