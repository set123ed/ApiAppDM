using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using static ApiAppDM.Models.CoachesInformation;

namespace ApiAppDM.Models
{
    public class Game
    {

        [JsonPropertyName("vteam")]
        VTeam vteam;
        [JsonPropertyName("hteam")]
        HTeam hteam;

       

        
    }
}
