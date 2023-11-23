using System.Text;

namespace appFP.repetitivos
{
    public partial class _16 : Form
    {
        public _16()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String Invertida = InvertirCadena(txtCadena.Text);
            txtInvertido.Text = Invertida.ToString();
        }
        public static String InvertirCadena(String Cadena)
        {
            StringBuilder Invertida = new StringBuilder();
            for (int i = Cadena.Length  -1; i >= 0; i--)
            {
               

                Invertida.Append(Cadena.ToCharArray()[i]);
            }
            return Invertida.ToString();
        }
        
    
  }

    }

