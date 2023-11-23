using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP.Secuenciales
{
    public partial class _04 : Form
    {
        public _04()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Pies = int.Parse(txtPies.Text);
            int Pulgadas = int.Parse(txtPulgadas.Text);

            double Estatura = (( (Pies * 12) + Pulgadas) * 2.54) / 100;

            txtEstatura.Text = Estatura.ToString("##.00") + " m";

        }
    }
}
