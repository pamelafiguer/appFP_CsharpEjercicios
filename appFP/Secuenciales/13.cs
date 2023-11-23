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
    public partial class _13 : Form
    {
        public _13()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int CO = int.Parse(txtCO.Text);
            int CA = int.Parse(txtCA.Text);

            double Hipotenusa = Math.Sqrt((Math.Pow(CO, 2)) + (Math.Pow(CA, 2)));

            txtHipotenusa.Text = Hipotenusa.ToString("##.00");


        }
    }
}
