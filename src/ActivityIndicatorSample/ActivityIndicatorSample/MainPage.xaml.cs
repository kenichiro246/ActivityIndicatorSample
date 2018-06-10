using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ActivityIndicatorSample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        public async void Button1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page1());
        }

        public async void Button2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page2());
        }

    }
}
