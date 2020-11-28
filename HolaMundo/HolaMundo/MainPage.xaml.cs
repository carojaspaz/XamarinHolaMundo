using HolaMundo.Core.Helpers;
using HolaMundo.Views.Security;
using Xamarin.Forms;

namespace HolaMundo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
            LoadInfo();
        }        

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"Ha hecho click { count } veces ";
        }

        void Logout_Clicked(object sender, System.EventArgs e)
        {
            Settings.SecurityToken = string.Empty;
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }

        void LoadInfo()
        {
            this.lblToken.Text = $"Token: {Settings.SecurityToken}";
        }
    }
}
