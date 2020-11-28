using HolaMundo.Core.Services;
using HolaMundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HolaMundo.Views.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeamPage : ContentPage
    {
        private int _id = 0;
        private TeamService _teamService;

        public Team SelectedTeam;
        public TeamPage()
        {
            InitializeComponent();
        }

        public TeamPage(int id)
        {
            InitializeComponent();
            _id = id;            
            _teamService = new TeamService();
            LoadTeam();
        }

        public void LoadTeam()
        {            
            SelectedTeam = _teamService.GetTeamById(_id);
            BindingContext = SelectedTeam;
        }
    }
}