using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page1());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page2());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page3());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page4());
        }
    }
}
