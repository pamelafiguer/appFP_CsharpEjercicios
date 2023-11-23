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
    public partial class _13 : Form
    {
        public _13()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Menor = int.Parse(txtMenores.Text);

            int Suma = 0;
            for (int i = 0; i <= Menor; i += 3)
            {
                if (i % 5 != 0)
                {
                    Suma += i;
                    txtRpta.AppendText(i + (Environment.NewLine));
                }
            }

            txtMultiplos.AppendText( " " + Suma);
        }
    }
}
