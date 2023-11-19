namespace appFP.Condicionales
{
    public partial class _10 : Form
    {
        public _10()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Nota1 = int.Parse(txtNota1.Text);
            int Nota2 = int.Parse(txtNota2.Text);
            int Nota3 = int.Parse(txtNota3.Text);
            int Nota4 = int.Parse(txtNota4.Text);
            int Nota5 = int.Parse(txtNota5.Text);

            double Mayor = Nota1;
            if (Nota2 >= Mayor) Mayor = Nota2;
            if (Nota3 >= Mayor) Mayor = Nota3;
            if (Nota4 >= Mayor) Mayor = Nota4;
            if (Nota5 >= Mayor) Mayor = Nota5;

            double Menor = Nota1;
            if (Nota2 <= Menor) Menor = Nota2;
            if (Nota3 <= Menor) Menor = Nota3;
            if (Nota4 <= Menor) Menor = Nota4;
            if (Nota5 <= Menor) Menor = Nota5;

            double Promedio = ((Nota1 + Nota2 + Nota3 + Nota4 + Nota5) - Menor - Mayor) / 3;

            txtMayor.Text = Mayor.ToString("##");
            txtMenor.Text = Menor.ToString("##");
            txtPromedio.Text = Promedio.ToString("##.00");




        }
    }
}
