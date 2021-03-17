using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using static ApiAppDM.Models.TeamSchedule;

namespace ApiAppDM.Models
{
    public class TeamSchedule
    {
        public class Internal
        {

            [JsonPropertyName("pubDateTime")]
            public string PubDateTime { get; set; }

            [JsonPropertyName("xslt")]
            public string Xslt { get; set; }

            [JsonPropertyName("eventName")]
            public string EventName { get; set; }
        }

        public class National
        {

            [JsonPropertyName("shortName")]
            public string ShortName { get; set; }

            [JsonPropertyName("longName")]
            public string LongName { get; set; }
        }

        public class Canadian
        {

            [JsonPropertyName("shortName")]
            public string ShortName { get; set; }

            [JsonPropertyName("longName")]
            public string LongName { get; set; }
        }

        public class VTeam
        {

            [JsonPropertyName("shortName")]
            public string ShortName { get; set; }

            [JsonPropertyName("longName")]
            public string LongName { get; set; }
        }

        public class HTeam
        {

            [JsonPropertyName("shortName")]
            public string ShortName { get; set; }

            [JsonPropertyName("longName")]
            public string LongName { get; set; }
        }

        public class Broadcasters
        {

            [JsonPropertyName("national")]
            public IList<National> National { get; set; }

            [JsonPropertyName("canadian")]
            public IList<Canadian> Canadian { get; set; }

            [JsonPropertyName("vTeam")]
            public IList<VTeam> VTeam { get; set; }

            [JsonPropertyName("hTeam")]
            public IList<HTeam> HTeam { get; set; }
        }

        public class Stream
        {

            [JsonPropertyName("streamType")]
            public string StreamType { get; set; }

            [JsonPropertyName("isOnAir")]
            public bool IsOnAir { get; set; }

            [JsonPropertyName("doesArchiveExist")]
            public bool DoesArchiveExist { get; set; }

            [JsonPropertyName("isArchiveAvailToWatch")]
            public bool IsArchiveAvailToWatch { get; set; }

            [JsonPropertyName("streamId")]
            public string StreamId { get; set; }

            [JsonPropertyName("duration")]
            public int Duration { get; set; }
        }

        public class DeepLink
        {

            [JsonPropertyName("broadcaster")]
            public string Broadcaster { get; set; }

            [JsonPropertyName("regionalMarketCodes")]
            public string RegionalMarketCodes { get; set; }

            [JsonPropertyName("iosApp")]
            public string IosApp { get; set; }

            [JsonPropertyName("androidApp")]
            public string AndroidApp { get; set; }

            [JsonPropertyName("desktopWeb")]
            public string DesktopWeb { get; set; }

            [JsonPropertyName("mobileWeb")]
            public string MobileWeb { get; set; }
        }

        public class Video
        {

            [JsonPropertyName("regionalBlackoutCodes")]
            public string RegionalBlackoutCodes { get; set; }

            [JsonPropertyName("canPurchase")]
            public bool CanPurchase { get; set; }

            [JsonPropertyName("isLeaguePass")]
            public bool IsLeaguePass { get; set; }

            [JsonPropertyName("isTNTOT")]
            public bool IsTNTOT { get; set; }

            [JsonPropertyName("tntotIsOnAir")]
            public bool TntotIsOnAir { get; set; }

            [JsonPropertyName("streams")]
            public IList<Stream> Streams { get; set; }

            [JsonPropertyName("deepLink")]
            public IList<DeepLink> DeepLink { get; set; }
        }



        //public class National
        //{

        //    [JsonPropertyName("streams")]
        //    public IList<Stream> Streams { get; set; }

        //    [JsonPropertyName("broadcasters")]
        //    public IList<object> Broadcasters { get; set; }
        //}


        public class Broadcaster
        {

            [JsonPropertyName("shortName")]
            public string ShortName { get; set; }

            [JsonPropertyName("longName")]
            public string LongName { get; set; }
        }

        //public class VTeam
        //{

        //    [JsonPropertyName("streams")]
        //    public IList<Stream> Streams { get; set; }

        //    [JsonPropertyName("broadcasters")]
        //    public IList<Broadcaster> Broadcasters { get; set; }
        //}



        //public class Broadcaster
        //{

        //    [JsonPropertyName("shortName")]
        //    public string ShortName { get; set; }

        //    [JsonPropertyName("longName")]
        //    public string LongName { get; set; }
        //}

        //public class HTeam
        //{

        //    [JsonPropertyName("streams")]
        //    public IList<Stream> Streams { get; set; }

        //    [JsonPropertyName("broadcasters")]
        //    public IList<Broadcaster> Broadcasters { get; set; }
        //}

        public class Audio
        {

            [JsonPropertyName("national")]
            public National National { get; set; }

            [JsonPropertyName("vTeam")]
            public VTeam VTeam { get; set; }

            [JsonPropertyName("hTeam")]
            public HTeam HTeam { get; set; }
        }

        public class Broadcast
        {

            [JsonPropertyName("broadcasters")]
            public Broadcasters Broadcasters { get; set; }

            [JsonPropertyName("video")]
            public Video Video { get; set; }

            [JsonPropertyName("audio")]
            public Audio Audio { get; set; }
        }

        public class Watch
        {

            [JsonPropertyName("broadcast")]
            public Broadcast Broadcast { get; set; }
        }

        public class Nugget
        {

            [JsonPropertyName("text")]
            public string Text { get; set; }
        }

        public class Playoffs
        {

            [JsonPropertyName("roundNum")]
            public string RoundNum { get; set; }

            [JsonPropertyName("confName")]
            public string ConfName { get; set; }

            [JsonPropertyName("seriesId")]
            public string SeriesId { get; set; }

            [JsonPropertyName("seriesSummaryText")]
            public string SeriesSummaryText { get; set; }

            [JsonPropertyName("isSeriesCompleted")]
            public bool IsSeriesCompleted { get; set; }

            [JsonPropertyName("gameNumInSeries")]
            public string GameNumInSeries { get; set; }

            [JsonPropertyName("isIfNecessary")]
            public bool IsIfNecessary { get; set; }

            //    [JsonPropertyName("vTeam")]
            //    public VTeam { get; set; }

            //[JsonPropertyName("hTeam")]
            //public HTeam { get; set; }
        }

        public class Standard
        {

            [JsonPropertyName("seasonStageId")]
            public int SeasonStageId { get; set; }

            [JsonPropertyName("gameId")]
            public string GameId { get; set; }

            [JsonPropertyName("statusNum")]
            public int StatusNum { get; set; }

            [JsonPropertyName("extendedStatusNum")]
            public int ExtendedStatusNum { get; set; }

            [JsonPropertyName("startTimeUTC")]
            public DateTime StartTimeUTC { get; set; }

            [JsonPropertyName("startDateEastern")]
            public string StartDateEastern { get; set; }

            [JsonPropertyName("isHomeTeam")]
            public bool IsHomeTeam { get; set; }

            [JsonPropertyName("watch")]
            public Watch Watch { get; set; }

            [JsonPropertyName("nugget")]
            public Nugget Nugget { get; set; }

            //    [JsonPropertyName("vTeam")]
            //    public VTeam { get; set; }

            //[JsonPropertyName("hTeam")]
            //public HTeam
            //{ get; set; }

            //[JsonPropertyName("playoffs")]
            //public Playoffs Playoffs { get; set; }
            //}

            public class League
            {

                [JsonPropertyName("lastStandardGamePlayedIndex")]
                public int LastStandardGamePlayedIndex { get; set; }

                [JsonPropertyName("standard")]
                public IList<Standard> Standard { get; set; }
            }

            public class TeamsSchedule
            {

                [JsonPropertyName("_internal")]
                public Internal Internal { get; set; }

                [JsonPropertyName("league")]
                public League League { get; set; }
            }
        }
    }
}
