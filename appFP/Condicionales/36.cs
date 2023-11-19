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
    public partial class _36 : Form
    {
        public _36()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Cuadernos = int.Parse(txtCuadernos.Text);

            int Pilot = 0;
            int Lucas = 0;
            int Faber = 0;

            if (Cuadernos < 12) ;
            else if (Cuadernos < 24) Lucas = Cuadernos / 4;
            else if (Cuadernos < 36) Faber = (Cuadernos / 4) * 2;
            else
                Pilot = (Cuadernos / 4) * 2;
            Faber = Cuadernos / 6;
            Lucas = Cuadernos / 12;

            txtLucas.Text = Lucas.ToString("##");
            txtFaber.Text = Faber.ToString("##");
            txtPilot.Text = Pilot.ToString("##");



            
        }
    }
}
