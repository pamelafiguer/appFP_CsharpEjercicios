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
    public partial class _06 : Form
    {
        public _06()
        {
            InitializeComponent();
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);
            int Inicio = int.Parse(txtInicio.Text);
            int Final = int.Parse(txtFinal.Text);

            txtRpta.AppendText("");

            for (int i = Inicio; i <= Final; i++)
                txtRpta.AppendText( Numero + " x " + i + " = " + Numero * i + Environment.NewLine);



        }
    }
}
