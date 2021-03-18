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
        public ObservableCollection<CoachesInformation> CoachesInfo { get; set; }
        //private ITeamScheduleService _teamScheduleService;
        public TeamScheduleViewModel(TeamScheduleService teamScheduleService)
        {
            //_teamScheduleService = teamScheduleService;
            GetCoachInfo();
        }

        //CoachesInformation coach = await 


        private async void GetCoachInfo()
        {


            CoachesInformation coach = new CoachesInformation();
            coach = await TeamScheduleService.GetCoachesAsync();

            if (coach != null)
            {
                //List<CoachesInformation> activlePlayersList = coach..Standard.Where(player => player.IsActive == true).ToList();
                CoachesInfo = new ObservableCollection<CoachesInformation>();
                //AllActivePlayers = new ObservableCollection<CoachesInformation>();
                //InternetConnection = true;
            }
            else
            {
                //InternetConnection = false;
                //await AlertServices.AlertAsync("Error", "No hay conexión a internet");
            }
        }
    }
}

   
            //else
            //{
            //    await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Alert", "No tienes Conexion a internet", "Ok");
