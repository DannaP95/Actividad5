using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Act_5
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();            
		}

        private void OnClick (object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page2(Convert.ToInt32(Intentos.SelectedItem)));
        }
    }
}
