namespace appFP.Condicionales
{
    public partial class _31 : Form
    {
        public _31()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Horas = int.Parse(txtHoras.Text);
            String Categoria = txtCategoria.Text;

            double Tarifa = 0;
            Tarifa = "A".Equals(Categoria) ? 21 : "B".Equals(Categoria) ? 19.5 : "C".Equals(Categoria) ? 17 : "D".Equals(Categoria) ? 15.5 : 0;
            double Bruto = Horas * Tarifa;

            double Descuento = 0;
            Descuento = Bruto > 2500 ? Bruto * 0.2 : Bruto * 0.15;
            double Neto = Bruto - Descuento;

            txtBruto.Text = Bruto.ToString("##.00");
            txtDescuento.Text = Descuento.ToString("##.00");
            txtNeto.Text = Neto.ToString("##.00");


        }
    }
}
