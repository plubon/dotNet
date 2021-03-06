﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FootballDataAPI.Responses
{

    public partial class AllLeaguesResponse
    {
        public class Self2
        {

            [JsonProperty("href")]
            public string Href { get; set; }
        }
    }

    public partial class AllLeaguesResponse
    {
        public class Teams2
        {

            [JsonProperty("href")]
            public string Href { get; set; }
        }
    }

    public partial class AllLeaguesResponse
    {
        public class Fixtures2
        {

            [JsonProperty("href")]
            public string Href { get; set; }
        }
    }

    public partial class AllLeaguesResponse
    {
        public class LeagueTable2
        {

            [JsonProperty("href")]
            public string Href { get; set; }
        }
    }

    public partial class AllLeaguesResponse
    {
        public class Links2
        {

            [JsonProperty("self")]
            public Self2 Self { get; set; }

            [JsonProperty("teams")]
            public Teams2 Teams { get; set; }

            [JsonProperty("fixtures")]
            public Fixtures2 Fixtures { get; set; }

            [JsonProperty("leagueTable")]
            public LeagueTable2 LeagueTable { get; set; }
        }
    }

    public partial class AllLeaguesResponse
    {

        [JsonProperty("_links")]
        public Links2 Links { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("league")]
        public string League { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("numberOfTeams")]
        public int NumberOfTeams { get; set; }

        [JsonProperty("numberOfGames")]
        public int NumberOfGames { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

}
