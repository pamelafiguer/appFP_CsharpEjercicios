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
    public partial class _09 : Form
    {
        public _09()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Ancho = int.Parse(txtAncho.Text);
            String Cuadro = " ";

            for (int i = 1; i <= Ancho * 2; i++) {
                Cuadro += " *";
            }
            Cuadro += (Environment.NewLine);

            for (int j = 1; j <= Ancho - 2; j++) {
                Cuadro += (" *");

                for (int k = 1; k <= Ancho * 2 + (Ancho * 3); k++) {
                    Cuadro += (" ");
                }
                Cuadro += (" *");
                Cuadro += (Environment.NewLine);
            }

            for (int i = 1; i <= Ancho * 2; i++)
            {
                Cuadro += (" *");
            }
            Cuadro += (Environment.NewLine);

            txtRpta.Text = Cuadro.ToString();
            
        }
      


        
    }
}
