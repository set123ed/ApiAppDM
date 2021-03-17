using System;
using Refit;
using System.Threading.Tasks;
using System.Net.Http;
using ApiAppDM.Models;
namespace ApiAppDM.Services

{
    public interface ITeamRefitApiService
    {
        
            [Get("/data/10s/prod/v1/2019/teams/{{teamName}}/schedule.json")]
            Task<HttpResponseMessage> GetTeamsSchedule(string name);
    }
}
