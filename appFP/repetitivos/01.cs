namespace appFP.Repetitivos
{
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Dividendo = int.Parse(txtDividendo.Text);
            int Divisor = int.Parse(txtDivisor.Text);

            int Cociente = 0;
            while (Dividendo >= Divisor)
            {
                Cociente++;
                Dividendo -= Divisor;
            }
            txtCociente.Text = Cociente.ToString("");
            txtResto.Text = Dividendo.ToString("");


        }
    }
}
