namespace appFP.Condicionales
{
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Angulos = int.Parse(txtAngulo.Text);

            String Clasificacion = Angulos == 0 ? "Nulo" : Angulos < 90 ? "Agudo" : Angulos == 90 ? "Recto" : Angulos < 180 ? "Obtuso" : Angulos == 180 ? "Llano" : Angulos < 360 ? "Concavo" : Angulos == 360 ? "Completo" : "Error";

            txtCalsificacion.Text = Clasificacion.ToString();
        }
    }
}
