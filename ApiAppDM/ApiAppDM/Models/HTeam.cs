using System;
using System.Text.Json.Serialization;

namespace ApiAppDM.Models
{
    public class HTeam
    {
        

            [JsonPropertyName("teamId")]
            public string TeamId { get; set; }

            [JsonPropertyName("triCode")]
            public string TriCode { get; set; }

            [JsonPropertyName("win")]
            public string Win { get; set; }

            [JsonPropertyName("loss")]
            public string Loss { get; set; }

            [JsonPropertyName("seriesWin")]
            public string SeriesWin { get; set; }

            [JsonPropertyName("seriesLoss")]
            public string SeriesLoss { get; set; }

            [JsonPropertyName("score")]
            public string Score { get; set; }

            //[JsonPropertyName("linescore")]
            //public IList<Linescore> Linescore { get; set; }
        
        public HTeam()
        {
        }
    }
}
