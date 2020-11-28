using HolaMundo.Core.Services;
using HolaMundo.Models;
using HolaMundo.Views.Home;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HolaMundo.Views.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        HomePage RootPage { get => Application.Current.MainPage as HomePage; }
        public IList<Team> Teams { get; private set; }
        private TeamService _teamService;
        public ListViewPage()
        {
            InitializeComponent();
            _teamService = new TeamService();
            LoadTeams();
        }

        private void LoadTeams()
        {
            Teams = _teamService.GetTeams();
            BindingContext = this; 
        }        

        private async void Team_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Team selectedItem = e.Item as Team;
            RootPage.IsPresented = false;
            await RootPage.Detail.Navigation.PushAsync(new TeamPage(selectedItem.Id));
        }
    }
}