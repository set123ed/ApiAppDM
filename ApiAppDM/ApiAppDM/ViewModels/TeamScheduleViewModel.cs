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
        public TeamScheduleViewModel(TeamScheduleService teamScheduleService)
        {
            //_teamScheduleService = teamScheduleService;
            GetCoachInfo();
        }

        //CoachesInformation coach = await 


        private async void GetCoachInfo()
        {

        }
    }
}

   