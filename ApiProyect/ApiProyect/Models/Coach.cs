using System;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace ApiProyect.Models
{
    public class Coach
    {


        public class Internal
        {

            [JsonProperty("pubDateTime")]
            public string pubDateTime { get; set; }

            [JsonProperty("igorPath")]
            public string igorPath { get; set; }

            [JsonProperty("xslt")]
            public string xslt { get; set; }

            [JsonProperty("xsltForceRecompile")]
            public string xsltForceRecompile { get; set; }

            [JsonProperty("xsltInCache")]
            public string xsltInCache { get; set; }

            [JsonProperty("xsltCompileTimeMillis")]
            public string xsltCompileTimeMillis { get; set; }

            [JsonProperty("xsltTransformTimeMillis")]
            public string xsltTransformTimeMillis { get; set; }

            [JsonProperty("consolidatedDomKey")]
            public string consolidatedDomKey { get; set; }

            [JsonProperty("endToEndTimeMillis")]
            public string endToEndTimeMillis { get; set; }
        }

        public class TeamSitesOnly
        {

            [JsonProperty("displayName")]
            public string displayName { get; set; }

            [JsonProperty("coachCode")]
            public string coachCode { get; set; }

            [JsonProperty("coachRole")]
            public string coachRole { get; set; }

            [JsonProperty("teamCode")]
            public string teamCode { get; set; }

            [JsonProperty("teamTricode")]
            public string teamTricode { get; set; }
        }

        public class Standard
        {

            [JsonProperty("firstName")]
            public string firstName { get; set; }

            [JsonProperty("lastName")]
            public string lastName { get; set; }

            [JsonProperty("isAssistant")]
            public bool isAssistant { get; set; }

            [JsonProperty("personId")]
            public string personId { get; set; }

            [JsonProperty("teamId")]
            public string teamId { get; set; }

            [JsonProperty("sortSequence")]
            public string sortSequence { get; set; }

            [JsonProperty("college")]
            public string college { get; set; }

            [JsonProperty("teamSitesOnly")]
            public TeamSitesOnly teamSitesOnly { get; set; }
        }

        public class League : INotifyPropertyChanged
        {

            [JsonProperty("standard")]
            public IList<Standard> standard { get; set; }

            public event PropertyChangedEventHandler PropertyChanged;
        }

        public class TeamLigue
        {

            [JsonProperty("_internal")]
            public Internal _internal { get; set; }

            [JsonProperty("league")]
            public League league { get; set; }
        }


    }
}
