using System;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.ObjectModel;

namespace ApiProyect.Models
{
    public class Coach
    {


        //public class Internal
        //{

        //    [JsonPropertyName("pubDateTime")]
        //    public string pubDateTime { get; set; }

        //    [JsonPropertyName("igorPath")]
        //    public string igorPath { get; set; }

        //    [JsonPropertyName("xslt")]
        //    public string xslt { get; set; }

        //    [JsonPropertyName("xsltForceRecompile")]
        //    public string xsltForceRecompile { get; set; }

        //    [JsonPropertyName("xsltInCache")]
        //    public string xsltInCache { get; set; }

        //    [JsonPropertyName("xsltCompileTimeMillis")]
        //    public string xsltCompileTimeMillis { get; set; }

        //    [JsonPropertyName("xsltTransformTimeMillis")]
        //    public string xsltTransformTimeMillis { get; set; }

        //    [JsonPropertyName("consolidatedDomKey")]
        //    public string consolidatedDomKey { get; set; }

        //    [JsonPropertyName("endToEndTimeMillis")]
        //    public string endToEndTimeMillis { get; set; }
        //}

        public class TeamSitesOnly
        {

            [JsonPropertyName("displayName")]
            public string displayName { get; set; }

            [JsonPropertyName("coachCode")]
            public string coachCode { get; set; }

            [JsonPropertyName("coachRole")]
            public string coachRole { get; set; }

            [JsonPropertyName("teamCode")]
            public string teamCode { get; set; }

            [JsonPropertyName("teamTricode")]
            public string teamTricode { get; set; }
        }

        public class Standard
        {

            [JsonPropertyName("firstName")]
            public string firstName { get; set; }

            [JsonPropertyName("lastName")]
            public string lastName { get; set; }

            [JsonPropertyName("isAssistant")]
            public bool isAssistant { get; set; }

            [JsonPropertyName("personId")]
            public string personId { get; set; }

            [JsonPropertyName("teamId")]
            public string teamId { get; set; }

            [JsonPropertyName("sortSequence")]
            public string sortSequence { get; set; }

            [JsonPropertyName("college")]
            public string college { get; set; }

            [JsonPropertyName("teamSitesOnly")]
            public TeamSitesOnly teamSitesOnly { get; set; }
        }

        public class League
        {
            [JsonPropertyName("standard")]
            public IList<Standard> Standard { get; set; }
        }


        public class _Coach : INotifyPropertyChanged
        {
            //[JsonPropertyName("internal")]
            //public IList<Internal> Intternal { get; set; }

            [JsonPropertyName("league")]
            public League League { get; set; }

            public event PropertyChangedEventHandler PropertyChanged;

            public static implicit operator ObservableCollection<object>(_Coach v)
            {
                throw new NotImplementedException();
            }
        }



    }
}
