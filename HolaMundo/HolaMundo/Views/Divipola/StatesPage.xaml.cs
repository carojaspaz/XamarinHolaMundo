using HolaMundo.Core.Api;
using HolaMundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HolaMundo.Views.Divipola
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatesPage : ContentPage
    {
        public IList<EntityDivisionModel> States { get; set; }
        public StatesPage()
        {
            InitializeComponent();            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadStates();
        }

        private async void LoadStates()
        {
            DivipolaApi divipolaApi = new DivipolaApi();
            States = new List<EntityDivisionModel>();
            activityIndicator.IsRunning = true;
            States = await divipolaApi.GetStatesAsync("co");
            activityIndicator.IsRunning = false;
            BindingContext = this;
        }
    }
}