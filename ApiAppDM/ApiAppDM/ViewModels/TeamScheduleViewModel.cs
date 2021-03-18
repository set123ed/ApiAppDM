using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;
using ApiAppDM.Models;
using ApiAppDM.Services;
using Xamarin.Essentials;
using System.Net.Http.Json;
using System.Text.Json;
using ApiAppDM.Views;


namespace ApiAppDM.ViewModels 
{
    public class TeamScheduleViewModel

    {
        //public ObservableCollection<Models.CoachesInformation> CoachesInfo = new ObservableCollection<Models.CoachesInformation>();

        private TeamScheduleService teamScheduleService;
        public CoachesInformation nContact { get; set; } = new Models.CoachesInformation();

        public TeamScheduleViewModel(TeamScheduleService teamScheduleService)
        {
            this.teamScheduleService = teamScheduleService;
            GetCoach();
        }

        private async void GetCoach()
        {
            HttpClient client = new HttpClient();
            var clientResponse = await client.GetStringAsync("http://data.nba.net/data/10s/prod/v1/2020/coaches.json");

            var coaches = JsonSerializer.Deserialize<List<CoachesInformation>>(clientResponse);

            //if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            //{
            //    CoachesInfo.Add(nContact);
            //    CoachesInfo = new ObservableCollection<CoachesInformation>();
            //}
            //else
            //{
            //    //await App.Current.MainPage.DisplayAlert("Failed Connection","Not Internet connection","Ok");
            //}
        }
    }

        
}

   