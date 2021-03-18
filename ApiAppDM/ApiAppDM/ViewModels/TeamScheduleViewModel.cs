using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using ApiAppDM.Models;
using ApiAppDM.Services;
using Xamarin.Essentials;

namespace ApiAppDM.ViewModels
{
    public class TeamScheduleViewModel 
    {
        public ObservableCollection<TeamSchedule.National> TeamInfo { get; set; } = new ObservableCollection<Models.TeamSchedule.National>();
        private ITeamScheduleService _teamScheduleService;
        public TeamScheduleViewModel(TeamScheduleService teamScheduleService)
        {
            //_teamScheduleService = teamScheduleService;
            GetInfoSchedule();
        }

        private async void GetInfoSchedule()
        {

            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                await TeamScheduleService.GetTeamsScheduleAsync();
            }
            else
            {
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Alert", "No tienes Conexion a internet", "Ok");
            }

        }
    }
}
