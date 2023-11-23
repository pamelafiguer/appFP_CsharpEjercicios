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
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);

            int Tope = Numero / (Numero % 2 + 2);
            String Divisores = "1";

            for (int i = 2; i <= Tope; i++)
                if (Numero % i == 0)
                    Divisores += "," + i;
            txtDivisores.Text = Divisores + "," + Numero.ToString();

        }
        private String Divisores (int Numero, int Contador, String rpta)
            {
            if ( Numero == Contador) return rpta += Numero;
            if (Numero % Contador == 0) rpta += Contador + ",";
            return Divisores(Numero, Contador + 1, rpta);
            }

        }
    }

