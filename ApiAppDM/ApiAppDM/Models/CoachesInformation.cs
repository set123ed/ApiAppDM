using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using static ApiAppDM.Models.CoachesInformation;

namespace ApiAppDM.Models
{
    public class CoachesInformation
    {
        public class TeamSitesOnly
        {
            public string DisplayName { get; set; }
            public string CoachCode { get; set; }
            public string CoachRole { get; set; }
            public string TeamCode { get; set; }
            public string TeamTricode { get; set; }
        }

        public class Standard
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public bool IsAssistant { get; set; }
            public string PersonId { get; set; }
            public string TeamId { get; set; }
            public string SortSequence { get; set; }
            public string College { get; set; }
            public TeamSitesOnly TeamSitesOnly { get; set; }
        }
        public class League
        {
            public IList<Standard> Standard { get; set; }
        }

        //public class CouchesInformationExample
        //{
        //    public Internal _internal { get; set; }
        //    public League league { get; set; }
        //}

    }
}
