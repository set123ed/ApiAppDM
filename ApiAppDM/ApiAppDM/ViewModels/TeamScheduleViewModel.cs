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
        public ObservableCollection<CoachesInformation> CoachesInfo { get; set; } = new ObservableCollection<CoachesInformation>();
        //private ITeamScheduleService _teamScheduleService;
        public TeamScheduleViewModel(TeamScheduleService teamScheduleService)
        {
            //_teamScheduleService = teamScheduleService;
            GetCoachInfo();
        }

        private async void GetCoachInfo()
        {
            //CoachesInformation coach = await 

            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                //var coachInfo = await 
            }
            else
            {
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Alert", "No tienes Conexion a internet", "Ok");
            }

        }
    }
}
