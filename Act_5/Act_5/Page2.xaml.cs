using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Act_5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{

        public int totaliteraciones;
        public int iteraciones = 1;
        public int total;
        public string operadorvisual;
        public int buenas = 0;
        public Page2(int preguntas)
        {
            InitializeComponent();
            this.totaliteraciones = preguntas;
            main();
        }

        public void main()
        {
            if (this.iteraciones <= this.totaliteraciones)
            {                
                Random rnd = new Random();
                int num1 = rnd.Next(1, 100);
                int num2 = rnd.Next(1, 100);
                int operador = rnd.Next(0, 2);
                if (operador == 0)
                {
                    this.total = num1 + num2;
                    this.operadorvisual = "+";
                }
                else
                {
                    this.total = num1 - num2;
                    this.operadorvisual = "-";
                }
                labeltotal.Text = "" + this.iteraciones + " de " + this.totaliteraciones;
                numero1.Text = "" + num1 + "";
                oper.Text = this.operadorvisual;
                numero2.Text = "" + num2 + "";
            }
            else
            {
                DisplayAlert("Resultado", "Resultado: " + this.buenas + " Buenas", "ok");
                Navigation.PushModalAsync(new MainPage());

            }
        }

        public void siguiente(Object sender, EventArgs e)
        {
            int resp = Convert.ToInt32(Respuesta.Text);
            if (this.total == resp)
            {
                this.buenas = this.buenas + 1;
            }

            this.iteraciones = this.iteraciones + 1;
            Respuesta.Text = "";
            main();
        }
    }
}