using System;
using System.Collections.Generic;

namespace ApiProyect.Models
{
    public class Coach
    {
        public Coach()
        {
        }
        public class Internal
        {
            public string PubDateTime { get; set; }
            public string IgorPath { get; set; }
            public string Xslt { get; set; }
            public string XsltForceRecompile { get; set; }
            public string XsltInCache { get; set; }
            public string XsltCompileTimeMillis { get; set; }
            public string XsltTransformTimeMillis { get; set; }
            public string ConsolidatedDomKey { get; set; }
            public string EndToEndTimeMillis { get; set; }
        }

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

        public class CoachInformation
        {
            public Internal Internal { get; set; }
            public League League { get; set; }
        }
    }
}
