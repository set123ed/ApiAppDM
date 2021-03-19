using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using ApiProyect.Models;

namespace ApiProyect.Services
{
    public class CoachApi : ICoachApi
    {
        public CoachApi()
        {
        }

        public async Task<Coach> GetCoach()
        {
            Coach retVal = null;

            HttpClient client = new HttpClient();
            var coachResponse = await client.GetAsync("http://data.nba.net/data/10s/prod/v1/2020/coaches.json");

            if(coachResponse.IsSuccessStatusCode)
            {
                var jsonPayload = await coachResponse.Content.ReadAsStringAsync();
                retVal = JsonSerializer.Deserialize<Coach>(jsonPayload);
            }

            return retVal;
        }
    }
}
