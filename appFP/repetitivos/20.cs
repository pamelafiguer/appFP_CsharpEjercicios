using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace appFP.repetitivos
{
    public partial class _20 : Form
    {
        public _20()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            List<int> Numeros = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                int Numero = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Número: "));
                Numeros.Add(Numero);
            }

            
            {
                foreach (int numero in Numeros)
                {
                    txtPanel.AppendText(numero + Environment.NewLine);
                }

            }

            int Max = Numeros.Max();
            int Min = Numeros.Min();
            int Suma = 0;

            foreach (int Numero  in  Numeros)
                
            {
                Suma += Numero;
                double Promedio = Suma / 10;
                txtPromedio.Text = Promedio.ToString("#.00");
            }

            txtMayor.Text = Max.ToString("##");
            txtMenor.Text = Min.ToString("##");
        }
    }
}
