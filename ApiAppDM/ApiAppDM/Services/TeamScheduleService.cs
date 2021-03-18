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


        public static async Task<CoachesInformation> GetCoachesAsync()
        {

            CoachesInformation Tschedule = null;
            //var cInternet = Connectivity.NetworkAccess;
                var refitClient = RestService.For<ITeamRefitApiService>("http://data.nba.net");
                CoachesInformation playersResponse = await refitClient.GetCoaches();
                return Tschedule;
        }
    }
}
