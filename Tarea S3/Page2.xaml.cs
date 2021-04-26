using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea_S3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void btnPromedio_Clicked(object sender, EventArgs e)
        {
            string esta = Convert.ToString(txtEstado);
            double Nota1 = Convert.ToDouble(txtNota1.Text);
            double Exa1 = Convert.ToDouble(txtExamen1.Text);
            double N1 = Nota1 * 0.3;
            double E1 = Exa1 * 0.2;
            double P1 = N1 + E1;
            txtNotaP1.Text = P1.ToString();

            double Nota2 = Convert.ToDouble(txtNota2.Text);
            double Exa2 = Convert.ToDouble(txtExamen2.Text);
            double N2 = Nota2 * 0.3;
            double E2 = Exa2 * 0.2;
            double P2 = N2 + E2;
            txtNotaP2.Text = P2.ToString();

            double NF = P1 + P2;
            txtNotaFinal.Text = NF.ToString();

            if (NF >= 7)
            {
                esta = "Aprobado".ToString();
            }
            if (NF >= 5 && NF <= 6.9)
            {
                esta = "Complementario".ToString();
            }
            if (NF < 4.9)
            {
                esta = "Reprobado".ToString();
            }

            txtEstado.Text = esta;

        }
    }
}