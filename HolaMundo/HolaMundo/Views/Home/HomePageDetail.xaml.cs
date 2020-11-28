using HolaMundo.Core.Helpers;
using HolaMundo.Views.Security;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HolaMundo.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePageDetail : ContentPage
    {
        public HomePageDetail()
        {
            InitializeComponent();
        }

        void Logout_Clicked(object sender, System.EventArgs e)
        {
            Settings.SecurityToken = string.Empty;
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}