using System;
using FootballDataAPI.Responses;
using System.Collections.Generic;
using Model.Enitites;

namespace FootballDataAPI
{
    internal class ResponseConverter
    {
        internal IList<League> FromAllLeaguesToLeagues(IList<AllLeaguesResponse> apiData)
        {
            List<League> ret = new List<League>();
            foreach(var apiLeague in apiData)
            {
                var x = new League();
                var temp = apiLeague.Links.Self.Href.Split('/');
                x.ApiId = Int32.Parse(temp[temp.Length - 1]);
                x.Description = apiLeague.League + apiLeague.Year;
                x.Name = apiLeague.Caption;
                x.UpdatedAt = new DateTime(2010,1,1);
                ret.Add(x);
            }
            return ret;
        }

        internal IList<Match> FromLeaguesMatches(LeaguesMatchesResponse apiData)
        {
            List<Match> ret = new List<Match>();
            foreach (var apiMatch in apiData.Fixtures)
            {
                var x = new Match();
                var temp = apiMatch.Links.Self.Href.Split('/');
                x.ApiId = Int32.Parse(temp[temp.Length - 1]);
                x.HomeTeam = new Team { Name = apiMatch.HomeTeamName };
                x.AwayTeam = new Team { Name = apiMatch.AwayTeamName };
                x.AwayTeamScore = apiMatch.Result.GoalsAwayTeam;
                x.HomeTeamScore = apiMatch.Result.GoalsHomeTeam;
                x.Date = DateTime.Parse(apiMatch.Date, null, System.Globalization.DateTimeStyles.RoundtripKind);
                ret.Add(x);
            }
            return ret;
        }

        internal Team FromTeam(TeamResponse result)
        {
            var x = new Team();
            var temp = result.Links.Self.Href.Split('/');
            x.ApiId = Int32.Parse(temp[temp.Length - 1]);
            x.Name = result.Name;
            x.LogoURI = result.CrestUrl;
            return x;
        }

        internal IList<Match> FromTeamsMatches(TeamsMatchesResponse apiData)
        {
            List<Match> ret = new List<Match>();
            foreach(var apiMatch in apiData.Fixtures)
            {
                var x = new Match();
                var temp = apiMatch.Links.Self.Href.Split('/');
                var leagueId = apiMatch.Links.Soccerseason.Href.Split('/');
                var y = apiMatch.Links.AwayTeam.Href.Split('/');
                var z = apiMatch.Links.HomeTeam.Href.Split('/');
                var aid = Int32.Parse(y[y.Length - 1]);
                var hid = Int32.Parse(z[z.Length - 1]);
                x.ApiId = Int32.Parse(temp[temp.Length - 1]);
                x.HomeTeam = new Team { Name = apiMatch.HomeTeamName, ApiId=hid  };
                x.AwayTeam = new Team { Name = apiMatch.AwayTeamName, ApiId=aid };
                x.AwayTeamScore = apiMatch.Result.GoalsAwayTeam;
                x.HomeTeamScore = apiMatch.Result.GoalsHomeTeam;
                x.Date = DateTime.Parse(apiMatch.Date, null, System.Globalization.DateTimeStyles.RoundtripKind);
                x.League = new League { ApiId = Int32.Parse(leagueId[leagueId.Length - 1]) };
                ret.Add(x);
            }
            return ret;
        }

        internal League FromLeague(LeagueResponse result)
        {
            var x = new League();
            var temp = result.Links.Self.Href.Split('/');
            x.ApiId = Int32.Parse(temp[temp.Length - 1]);
            x.Description = result.League + result.Year;
            x.Name = result.Caption;
            x.UpdatedAt = DateTime.Parse(result.LastUpdated, null, System.Globalization.DateTimeStyles.RoundtripKind);
            return x;
        }

        internal IList<Player> FromTeamsPlayers(TeamsPlayersResponse result)
        {
            List<Player> ret = new List<Player>();
            foreach(var apiPlayer in result.Players)
            {
                var x = new Player();
                x.Name = apiPlayer.Name;
                x.Nationality = apiPlayer.Nationality;
                ret.Add(x);
            }
            return ret;
        }

        internal List<Team> FromLeaguesTeams(LeaguesTeamsResponse apiData)
        {
            List<Team> ret = new List<Team>();
            foreach(var apiTeam in apiData.Teams)
            {
                var x = new Team();
                var temp = apiTeam.Links.Self.Href.Split('/');
                x.ApiId = Int32.Parse(temp[temp.Length - 1]);
                x.LogoURI = apiTeam.CrestUrl;
                x.Name = apiTeam.Name;
                x.UpdatedAt = new DateTime(2010,1,1);
                ret.Add(x);
            }
            return ret;
        }
    }
}