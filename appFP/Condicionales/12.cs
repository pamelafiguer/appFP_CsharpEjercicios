using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP.Condicionales
{
    public partial class _12 : Form
    {
        public _12()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);

            String[] Dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            String NDias = Numero >= 1 && Numero <= 7 ? Dias[Numero - 1]: "Error";

            txtDia.Text = NDias.ToString();
            
        }
    }
}
