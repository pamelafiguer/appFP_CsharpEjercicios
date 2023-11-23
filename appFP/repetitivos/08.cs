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
    public partial class _08 : Form
    {
        public _08()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Base = int.Parse(txtBase.Text);
            int Exponente = int.Parse(txtExponente.Text);

            double Resultado = Math.Pow(Base, Exponente);

            txtPotencia.Text = Resultado.ToString("##");
        }
    }
}
