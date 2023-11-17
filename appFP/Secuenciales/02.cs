namespace appFP.Secuenciales
{
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Metros = int.Parse(txtMetros.Text);

            double Centimetros = Metros * 100;
            double Pulgadas = Centimetros / 2.54;
            double Pies = Pulgadas / 12;
            double Yardas = Pies / 3;

            txtCentimetros.Text = Centimetros.ToString("##.00");
            txtPulgadas.Text = Pulgadas.ToString("##.00");
            txtPies.Text = Pies.ToString("##.00");
            txtYardas.Text = Yardas.ToString("##.00");




        }
    }
}
