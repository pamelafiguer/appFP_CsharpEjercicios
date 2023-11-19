namespace appFP.Condicionales
{
    public partial class _27 : Form
    {
        public _27()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Monto = int.Parse(txtMonto.Text);

            double Bruto = 600 + (0.15 * Monto);
            double Descuento;
            if (Bruto > 1800) Descuento = 0.10 * Bruto; else Descuento = 0.05 * Bruto;
            double Polos;
            if (Monto > 1000) Polos = 3; else Polos = 1;

            txtBruto.Text = Bruto.ToString("##.00");
            txtDescuento.Text = Descuento.ToString("##.00");
            txtNeto.Text = (Bruto - Descuento).ToString("##.00");
            txtPolos.Text = Polos.ToString("##");


        }
    }
}
