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
    public partial class _20 : Form
    {
        public _20()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int NA = int.Parse(txtA.Text);
            int NB = int.Parse(txtB.Text);
            int NC = int.Parse(txtC.Text);

            String Orden;
            if (NA < NB && NB < NC) Orden = "Ascendente";
            else if (NA > NB && NB > NC) Orden = "Descendente";
            else Orden = "Desordenado";

            txtOrden.Text = Orden;

        }
    }
}
