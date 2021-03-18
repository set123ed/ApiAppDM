using System;
using System.Net.Http;
using System.Threading.Tasks;
using Refit;
using ApiAppDM.Models;
using Xamarin.Essentials;
using System.Text.Json;

namespace ApiAppDM.Services
{
    public class TeamScheduleService
    {


        public static async Task<TeamSchedule> GetTeamsScheduleAsync()
        {

            TeamSchedule Tschedule = null;
            var cInternet = Connectivity.NetworkAccess;

            if (cInternet ==  NetworkAccess.Internet)
            {
                var refitClient = RestService.For<ITeamRefitApiService>("http://data.nba.net");

                ScoreBoard playersResponse = await refitClient.GetTeamsSchedule();
                //if (playersResponse.IsSuccessStatusCode)
                //{
                    //var jsonPayload = await playersResponse.Content.ReadAsStringAsync();
                    //Tschedule = JsonSerializer.Deserialize<TeamSchedule>(jsonPayload);
                //}



            }
            return Tschedule;
        }
    }
}
