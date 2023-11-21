using Boolean = System.Boolean;

namespace appFP.Condicionales
{
    public partial class _39 : Form
    {
        public _39()
        {
            InitializeComponent();
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Horas = (int)float.Parse(txtHoras.Text);
            int Defectuosos = int.Parse(txtDef.Text);
            int Nodef = int.Parse(txtNodef.Text);

            Boolean c1 = Horas < 1.5;
            Boolean c2 = Defectuosos < 300;
            Boolean c3 = Nodef > 10000;

            if (c1 == true & c2 == true & c3 == false) txtEficiencia.Text = "Grado 12";
            else if (c1 == true & c2 == false & c3 == true) txtEficiencia.Text = "Grado 13";
            else if (c1 == false & c2 == true & c3 == true) txtEficiencia.Text = "Grado 15";
            else if (c1 == true & c2 == false & c3 == false) txtEficiencia.Text = "Grado 7";
            else if (c1 == false & c2 == true & c3 == false) txtEficiencia.Text = "Grado 8";
            else if (c1 == false & c2 == false & c3 == true) txtEficiencia.Text = "Grado 9";
            else if (c1 == false & c2 == false & c3 == false) txtEficiencia.Text = "Grado 5";


        }

      
    }
}
