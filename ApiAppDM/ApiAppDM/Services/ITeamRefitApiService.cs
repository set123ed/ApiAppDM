using System;
using Refit;
using System.Threading.Tasks;
using System.Net.Http;
using ApiAppDM.Models;
using System.Collections.Generic;

namespace ApiAppDM.Services

{
    public interface ITeamRefitApiService
    {
        
            [Get("/data/10s/prod/v1/2020/coaches.json")]
            Task <CoachesInformation> GetCoaches();
    }
}
