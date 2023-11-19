namespace appFP.Condicionales
{
    public partial class _19 : Form
    {
        public _19()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String Genero = (txtGenero.Text);
            int Edad = int.Parse(txtEdad.Text);

            String Categoria;
            if (Genero.Equals("Femenino"))
                if (Edad < 23) Categoria = "FA"; else Categoria = "FB";
            else
                if (Edad < 25) Categoria = "MA"; else Categoria = "MB";

            txtCategoria.Text = Categoria;
        }
    }
}
