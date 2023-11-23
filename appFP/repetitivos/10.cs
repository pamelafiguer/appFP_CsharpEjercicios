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
    public partial class _10 : Form
    {
        public _10()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Contador = 0;
            for (int i = 1000; i < 10000; i++)
            {
                int SumaPares = 0;
                int SumaImpares = 0;
                int Numero = i;

                while (Numero > 0)
                {
                    int digito = Numero % 10;
                    if (digito % 2 == 0)
                        SumaPares += digito;
                    else
                        SumaImpares += digito;

                    Numero /= 10;

                    if (SumaPares == SumaImpares)
                    {
                        txtRpta.AppendText(i + (Environment.NewLine));
                        Contador++;
                    }

                    txtNumero.Text = Contador.ToString("Hay " ) + Contador;


                }
            }
        }
    }
}
