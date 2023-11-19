namespace appFP.Condicionales
{
    public partial class _05 : Form
    {
        public _05()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);

            double C1 = (Numero / 1000);
            double C2 = ((Numero % 1000) / 100);
            double C3 = (((Numero % 1000) % 100) / 10);
            double C4 = Numero % 10;

            double Mayor = C1;
            if (C2 > Mayor) Mayor = C2;
            if (C3 > Mayor) Mayor = C3;
            if (C4 > Mayor) Mayor = C4;

            double Menor = C1;
            if (C2 < Menor) Menor = C2;
            if (C3 < Menor) Menor = C3;
            if (C4 < Menor) Menor = C4;

            double Nuevo = (Mayor * 10) + Menor;

            txtMayor.Text = Mayor.ToString("##");
            txtMenor.Text = Menor.ToString("##");
            txtNuevo.Text = Nuevo.ToString("##");


        
    }
    }
}
