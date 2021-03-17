using System;
using System.Net.Http;
using System.Threading.Tasks;
using Refit;
using ApiAppDM.Models;
using Xamarin.Essentials;
using System.Text.Json;

namespace ApiAppDM.Services
{
    public class TeamScheduleService : ITeamScheduleService
    {


        public async Task<TeamSchedule> GetTeamsScheduleAsync()
        {

            var teamName = "lakers";
            TeamSchedule Tschedule = null;
            var cInternet = Connectivity.NetworkAccess;

            
                var refitClient = RestService.For<ITeamRefitApiService>("http://data.nba.net");

                var playersResponse = await refitClient.GetTeamsSchedule(teamName);
                if (playersResponse.IsSuccessStatusCode)
                {
                    var jsonPayload = await playersResponse.Content.ReadAsStringAsync();
                    Tschedule = JsonSerializer.Deserialize<TeamSchedule>(jsonPayload);
                }

            
            return Tschedule;
        }
    }
}
