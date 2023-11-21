using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP.Condicionales
{
    public partial class _38 : Form
    {
        public _38()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Dia = int.Parse(txtDia.Text);
            int Mes = int.Parse(txtMes.Text);
            int Año = int.Parse(txtAño.Text);

            String[] Listames = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            String NombreMes = Listames[Mes - 1];

            Boolean Bisiesto;
            if (((Año) % 4 == 0 & Año % 100 != 0) | Año % 400 == 0) Bisiesto = true;
            else Bisiesto = false;

            int Diames = 0;
            switch (Mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 10:
                case 12:
                    Diames = 31; break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Diames = 30; break;

                case 2:
                    Diames = Bisiesto == true ? 29 : 28; break;
            }
            txtNMes.Text = NombreMes.ToString();

            int Transcurso = 0;
            for( int i = 1; i < Mes; i++)
            {
                Transcurso += Diames + Dia;
                txtDMes.Text = Diames.ToString("##");
                txtNMes.Text = NombreMes.ToString();
                txtTranscurso.Text = Transcurso.ToString("##");

            }
        }
    }
}
