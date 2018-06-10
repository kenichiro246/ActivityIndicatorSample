using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ActivityIndicatorSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
        }

        public void Button1_Clicked(object sender, EventArgs e)
        {
            ActivityIndicator1.IsRunning = !ActivityIndicator1.IsRunning;
        }

        public async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}