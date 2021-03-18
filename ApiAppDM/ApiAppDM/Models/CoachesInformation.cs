using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using static ApiAppDM.Models.CoachesInformation;

namespace ApiAppDM.Models
{
    public class CoachesInformation
    {

        public class Standard
        {

            [JsonPropertyName("firstName")]
            public string FirstName { get; set; }

            [JsonPropertyName("lastName")]
            public string LastName { get; set; }

            [JsonPropertyName("isAssistant")]
            public bool IsAssistant { get; set; }

            [JsonPropertyName("personId")]
            public string PersonId { get; set; }

            [JsonPropertyName("teamId")]
            public string TeamId { get; set; }

            [JsonPropertyName("sortSequence")]
            public string SortSequence { get; set; }

            [JsonPropertyName("college")]
            public string College { get; set; }

            [JsonPropertyName("teamSitesOnly")]
            public TeamSitesOnly TeamSitesOnly { get; set; }
        }
        public class TeamSitesOnly
        {

            [JsonPropertyName("displayName")]
            public string DisplayName { get; set; }

            [JsonPropertyName("coachCode")]
            public string CoachCode { get; set; }

            [JsonPropertyName("coachRole")]
            public string CoachRole { get; set; }

            [JsonPropertyName("teamCode")]
            public string TeamCode { get; set; }

            [JsonPropertyName("teamTricode")]
            public string TeamTricode { get; set; }
        }

        public class CouchesInformation
        {

            //[JsonPropertyName("_internal")]
            //public Internal Internal { get; set; }

            //[JsonPropertyName("league")]
            //public League League { get; set; }
        }
    }
}
