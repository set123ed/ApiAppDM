using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApiAppDM.Models
{
    public class ScoreBoard
    {
        [JsonPropertyName("games")]
        List<Game> games;

        public ScoreBoard()
        {
        }
    }
}
