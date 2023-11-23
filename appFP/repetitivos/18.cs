using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appFP.repetitivos
{
    public partial class _18 : Form
    {
        public _18()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String Texto = txtTexto.Text;
            int Largo = Texto.Length;

            int Inicio = 0;
            while ((Inicio < Largo && Char.IsWhiteSpace(Text.ToCharArray()[Inicio]))) ;
            {
                Inicio++;
            }
            txtM1.Text = Texto.Substring(Inicio);

            int Fin = Largo - 1;
            while (Fin >= 0 && Char.IsWhiteSpace(Texto.ToCharArray()[Fin])) ;
            {
                Fin--;
            }
            txtM2.Text = Texto.Substring(0, Fin + 1);
            txtM3.Text = Texto.Substring(0, Fin + 1);

        }

        
    }
}
