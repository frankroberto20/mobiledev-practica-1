using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Login
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (username.Text == null || username.Text == "" || password.Text == null || password.Text == "")
            {
                await DisplayAlert ("Error", "User and Password fields can't be empty", "OK");
            }
            else
            {
                await DisplayAlert ("Welcome!", $"Hello {username.Text}", "OK");
            }
        }
    }
}
