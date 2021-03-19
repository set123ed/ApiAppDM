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
        public CoachApi()
        {
        }

        public async Task<Standard> GetCoach()
        {
            var retVal = null;

            HttpClient client = new HttpClient();
            var coachResponse = await client.GetStringAsync("http://data.nba.net/data/10s/prod/v1/2020/coaches.json");

            if(coachResponse.IsSuccessStatusCode)
            {

                //var jsonPayload = await coachResponse.Content.ReadAsStringAsync();
                Coach _coach = JsonConvert.DeserializeObject<Coach>(coachResponse);
                Standard _standard = _coach.
            }

            return retVal;
        }
    }
}
