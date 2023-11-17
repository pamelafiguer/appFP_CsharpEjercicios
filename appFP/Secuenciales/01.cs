namespace appFP.Secuenciales
{
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Varones = int.Parse(txtVarones.Text);
            int Mujeres = int.Parse(txtMujeres.Text);

            int Total = Varones + Mujeres;
            double PVarones = Varones * 100 / Total;
            double PMujeres = Mujeres * 100 / Total;

            lblPVarones.Text = PVarones.ToString("##.00") + " %";
            lblPMujeres.Text = PMujeres.ToString("##.00") + " %";
        }

       
    }
}
