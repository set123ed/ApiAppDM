using System;
using System.Threading.Tasks;
using ApiAppDM.Models;
using System.Net.Http;
using System.Text.Json;

namespace TeamApiService.Services
{
    public class TeamApiService : ITeamApiService
    {
        public async Task<TeamSchedule> GetTeamScheduleInformation()
        {
            HttpClient client = new HttpClient();
            var teamInfoResponse = await client.GetAsync("http://data.nba.net/data/10s/prod/v1/2016/teams/lakers/schedule.json");

            return JsonSerializer.Deserialize<TeamSchedule>(await teamInfoResponse.Content.ReadAsStringAsync()); 

        }
    }
}
