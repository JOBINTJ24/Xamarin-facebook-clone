using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace login_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registerpage : ContentPage
    {
        public Registerpage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConform.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                // Display an error message or handle the validation failure
                DisplayAlert("Error", "Please fill in all fields", "OK");
                return;
            }

            if (password != confirmPassword)
            {
                // Display an error message or handle the validation failure
                DisplayAlert("Error", "Password and Confirm Password must match", "OK");
                return;
            }
            Navigation.PushAsync(new LoginUI());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginUI());

        }
    }
}