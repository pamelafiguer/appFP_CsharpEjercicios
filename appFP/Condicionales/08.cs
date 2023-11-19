namespace appFP.Condicionales
{
    public partial class _08 : Form
    {
        public _08()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int Nota1 = int.Parse(txtNota1.Text);
            int Nota2 = int.Parse(txtNota2.Text);
            int Nota3 = int.Parse(txtNota3.Text);

            double Propina = 20;

            if (Nota1 > 12) Propina += 5;
             if (Nota2 > 12) Propina += 5;
              if (Nota3 > 12) Propina += 5;

            txtMonto.Text = Propina.ToString("##");



            

        }
    }
}
