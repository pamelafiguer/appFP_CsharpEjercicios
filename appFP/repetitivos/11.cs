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
    public partial class _11 : Form
    {
        public _11()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Contador = 0;
            for (int i = 100; i < 1000; i++)
                if (Copicuas(i))
                    Contador++;
            txtCopicuas.Text = Contador.ToString() + " Numeros";

        }
        public static bool Copicuas(int n)
        {
            int Original = n;
            int Reverso = 0;
            while (n > 0) {
                int Numero = n % 10;
                Reverso = Reverso * 10 + Numero;
                n /= 10;
            }
            return Original == Reverso;

        }
    }
}
