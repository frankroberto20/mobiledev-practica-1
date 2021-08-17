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

        private async void OnButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameEntry.Text) || string.IsNullOrEmpty(passwordEntry.Text))
            {
                await DisplayAlert ("Error", "User and Password fields can't be empty", "OK");
            }
            else
            {
                await DisplayAlert ("Welcome!", $"Hello {usernameEntry.Text}", "OK");
            }
        }
    }
}
