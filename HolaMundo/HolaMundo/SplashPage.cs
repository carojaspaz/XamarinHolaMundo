using HolaMundo.Core.Helpers;
using HolaMundo.Views.Home;
using HolaMundo.Views.Security;
using Xamarin.Forms;

namespace HolaMundo
{
    public class SplashPage : ContentPage
    {
        Image splashImage;

        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "splash.png",
                WidthRequest = 100.0,
                HeightRequest = 100.0
            };
            
            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);
            
            AbsoluteLayout.SetLayoutBounds(splashImage,
                new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            
            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("#FFFFFF");
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //--------------
            await splashImage.ScaleTo(1, 5000);
            //TODO: Security Logic
            string token = Settings.SecurityToken;
            if (string.IsNullOrEmpty(token))
            {
                Application.Current.MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                Application.Current.MainPage = new HomePage();
            }            
        }

    }
}
