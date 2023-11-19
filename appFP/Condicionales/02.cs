namespace appFP.Condicionales
{
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Unidades = int.Parse(txtUnidades.Text);

            int Compra = Unidades * 20;
            double Descuento = (Compra >= 700 ? 0.16 : Compra <= 500 ? 0.12 : 0.14) * Compra;
            int Caramelos = Unidades < 50 ? 5 : Unidades > 100 ? 15 : 10;
            double Total = Compra - Descuento;

            txtImporte.Text = Compra.ToString("##.00");
            txtDescuento.Text = Descuento.ToString("##.00");
            txtCaramelos.Text = Caramelos.ToString("##");
            txtTotal.Text = Total.ToString("##.00");





        }
    }
}
