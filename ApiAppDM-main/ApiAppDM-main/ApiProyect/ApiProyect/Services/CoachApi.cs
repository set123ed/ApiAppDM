using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using ApiProyect.Models;
using Newtonsoft.Json;

namespace ApiProyect.Services
{
    public class CoachApi : ICoachApi
    {
   
        public async Task<Coach.JsonObject> GetLeague()
        {
            Coach.JsonObject retVal = null;

            HttpClient client = new HttpClient();
            var coachResponse = await client.GetAsync("http://data.nba.net/data/10s/prod/v1/2020/coaches.json");

            if(coachResponse.IsSuccessStatusCode)
            {
                var jsonPayload = await coachResponse.Content.ReadAsStringAsync();
                retVal = JsonConvert.DeserializeObject<Coach.JsonObject>(jsonPayload);
            }

            return retVal;
        }

        
    }
}
