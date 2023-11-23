namespace appFP.repetitivos
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

            txtRpta.Text = "";

            for (int i = 1; i <= 12; i++) 
                    

                txtRpta.AppendText(Numero + " x " + i + " = " + (Numero * i) + Environment.NewLine);
            
        }

        
        

        }
    }

