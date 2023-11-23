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
    public partial class _17 : Form
    {
        public _17()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String Texto = txtTexto.Text;
            String Sub = txtSub.Text;

            int Indice = Texto.IndexOf(Sub);
            txtResultado.Text = (Indice + "").ToString(); ;
        }
    }
}
