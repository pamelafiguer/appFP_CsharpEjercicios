using System.Diagnostics.Eventing.Reader;

namespace appFP.Condicionales
{
    public partial class _37 : Form
    {
        public _37()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Pamela = int.Parse(txtPamela.Text);
            int Fanny = int.Parse(txtFanny.Text);
            int Carol = int.Parse(txtCarol.Text);

            int [] Candidatas = { Pamela, Carol, Fanny};
            Array.Sort(Candidatas);

            int Total = Pamela + Carol + Fanny;
            int Mitad = Total / 2 + 1;

            if (Pamela == Carol & Carol == Fanny)
            {
                txtGanadora.Text = "Anulado";
                txtSegundo.Text = "Anulado";
                txtTercero.Text = "Anulado";}
            else if (Pamela >= Mitad)
            {
                txtGanadora.Text = "Pamela";
                if (Carol == Fanny)
                {
                    txtGanadora.Text = "Anulado";
                    txtSegundo.Text = "Anulado";
                    txtTercero.Text = "Anulado";
                }
                else if (Carol == Candidatas[1])
                {
                    txtSegundo.Text = "Carol";
                    txtTercero.Text = "Fanny";
                }
                else if(Fanny == Candidatas[1])
                {
                    txtSegundo.Text = "Fanny";
                    txtTercero.Text = "Carol";
                }
            }
            else if (Carol >= Mitad )
            {
                txtGanadora.Text = "Carol";
                if (Pamela == Fanny)
                {
                    txtGanadora.Text = "Anulado";
                    txtSegundo.Text = "Anulado";
                    txtTercero.Text = "Anulado";
                }
                else if (Pamela == Candidatas[1])
                {
                    txtSegundo.Text = "Pamela";
                    txtTercero.Text = "Fanny";
                }
                else if (Fanny == Candidatas[1])
                {
                    txtSegundo.Text = "Fanny";
                    txtTercero.Text = "Pamela";
                }
            }
            else if (Fanny >= Mitad)
            {
                txtGanadora.AppendText("Fanny");
                if (Carol == Pamela)
                {
                    txtGanadora.Text = "Anulado";
                    txtSegundo.Text = "Anulado";
                    txtTercero.Text = "Anulado";
                }
            else if (Carol == Candidatas[1])
                {
                    txtSegundo.Text = "Carol";
                    txtTercero.Text = "Pamela";
                }
            else if (Pamela == Candidatas[1])
                {
                    txtSegundo.Text = "Pamela";
                    txtTercero.Text = "Carol";
                }
            }
    else
            {
                txtGanadora.Text = "Segunda Vuelta";
                txtSegundo.Text = "Segunda Vuelta";
                txtTercero.Text = "Segunda Vuelta";
            }
        }
    }
}
