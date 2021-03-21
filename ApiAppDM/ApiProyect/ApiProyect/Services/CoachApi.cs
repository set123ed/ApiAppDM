using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using ApiProyect.Models;
using Newtonsoft.Json;
using static ApiProyect.Models.Coach;

namespace ApiProyect.Services
{
    public class CoachApi : ICoachApi
    {
   
        public async Task<_Coach> GetLeague()
        {
            _Coach retVal = null;

            HttpClient client = new HttpClient();
            var coachResponse = await client.GetAsync("http://data.nba.net/data/10s/prod/v1/2020/coaches.json");

            if(coachResponse.IsSuccessStatusCode)
            {
                var jsonPayload = await coachResponse.Content.ReadAsStringAsync();
                retVal = System.Text.Json.JsonSerializer.Deserialize<_Coach>(jsonPayload);
            }

            return retVal;
        }

        
    }
}
