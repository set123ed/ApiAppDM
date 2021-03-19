using System;
using System.Collections.Generic;

namespace ApiProyect.Models
{
    public class Coach
    {
        public Coach()
        {
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
            //public TeamSitesOnly TeamSitesOnly { get; set; }
        }

        //public class League
        //{
        //    public IList<Standard> Standard { get; set; }
        //}

        //public class CoachInformation
        //{
        //    //public Internal Internal { get; set; }
        //    public League League { get; set; }
        //}
    }
}
