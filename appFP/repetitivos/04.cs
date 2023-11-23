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
    public partial class _04 : Form
    {
        public _04()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);
            int cantidad = int.Parse(txtCantidad.Text);

            String SMultiplos = "" + Numero;

            for (int i = 2; i <= cantidad;)
                SMultiplos += "," + (Numero * i++);

            txtMultiplos.Text = SMultiplos.ToString();


        }
    }
}
