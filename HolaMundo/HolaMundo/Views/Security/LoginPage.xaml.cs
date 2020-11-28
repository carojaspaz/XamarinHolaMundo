using HolaMundo.Core.Helpers;
using HolaMundo.Views.Home;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HolaMundo.Views.Security
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void Login_Clicked(object sender, System.EventArgs e)
        {
            Settings.SecurityToken = Guid.NewGuid().ToString();
            Application.Current.MainPage = new HomePage();
        }
    }
}