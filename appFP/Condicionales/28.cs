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
    public partial class _28 : Form
    {
        public _28()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Horas = int.Parse(txtF24.Text);

            String Hora12;
            if (Horas >= 0 && Horas <= 23) ;
            if (Horas == 0) Hora12 = "12 AM";
            else if (Horas < 12) Hora12 = Horas + " AM";
            else if (Horas == 12) Hora12 = "12 PM";
            else Hora12 = (Horas - 12) + " PM";

            txtF12.Text = (Horas > 24 ? Hora12 = "Error" : Hora12).ToString();



        }
    }
}
