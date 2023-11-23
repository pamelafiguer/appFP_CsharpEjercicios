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
    public partial class _14 : Form
    {
        public _14()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);

            txtPrimo.Text = Primo(Numero) ? "Primo" : "No es primo";
        }
        public static Boolean
            Primo( int Numero)
        {
            if (Numero < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(Numero); i++)
            {
                if (Numero % i == 0)
                {
                    return false;
                }
            }
            return true;
            
                
            
        }
            

    }
}
