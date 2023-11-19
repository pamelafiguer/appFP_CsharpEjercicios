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
    public partial class _24 : Form
    {
        public _24()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Monto = int.Parse(txtMonto.Text);

            double Sueldo = Monto * 0.10;
            double Excedente = Monto - 5000;

            if (Excedente > 0) ;
            double Bono = Math.Floor(Excedente / 500) * 25;
            Sueldo += Bono;

            txtSueldo.Text = Sueldo.ToString("##.00");




        }
    }
}
