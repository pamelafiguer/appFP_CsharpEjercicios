namespace appFP.repetitivos
{
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Multiplicando = int.Parse(txtMultiplicando.Text);
            int Multiplicador = int.Parse(txtMultiplicador.Text);

            for (int Producto = Multiplicando; Multiplicador-- > 1; Multiplicando += Producto) ;

            txtProducto.Text = Multiplicando.ToString("");

        }
    }
}
