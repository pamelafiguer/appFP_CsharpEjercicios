﻿namespace appFP.Condicionales
{
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Unidades = int.Parse(txtUnidades.Text);

            int Precio = Unidades <= 25 ? 27 : Unidades >= 51 ? 23 : 25;
            int Compra = Unidades * Precio;

            double Descuento = (Unidades > 50 ? 0.15 : 0.05) * Compra;
            double Total = Compra - Descuento;

            txtPrecio.Text = Precio.ToString("##.00");
            txtImporte.Text = Compra.ToString("##.00");
            txtDescuento.Text = Descuento.ToString("##.00");
            txtTotal.Text = Total.ToString("##.00");











        }
    }
}
