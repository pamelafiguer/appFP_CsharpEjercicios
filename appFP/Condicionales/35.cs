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
    public partial class _35 : Form
    {
        public _35()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Codigo = int.Parse(txtCodigo.Text);
            String Empleado = "";

            if (Codigo % 2 == 0 & Codigo % 3 == 0 & Codigo % 5 == 0) Empleado = "Administrativo";
            else if (Codigo % 3 == 0 & Codigo % 5 == 0) Empleado = "Directivo";
            else if (Codigo % 2 == 0) Empleado = "Vendedor";
            else if (Codigo % 2 != 0 & Codigo % 3 != 0 & Codigo % 5 != 0) Empleado = "Seguridad";

            txtEmpleado.Text = Empleado.ToString();


        }
    }
}
