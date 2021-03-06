﻿using FootballDataAPI.Responses;
using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDataAPI
{
    public class FootballAPIClient
    {
        private ApiRequest _request;
        private ResponseConverter _converter;

        private void getConverter()
        {
            if (_converter == null)
                _converter = new ResponseConverter();
        }
        public IList<League> GetAllLeagues()
        {
            _request = new ApiRequest("http://api.football-data.org/v1/soccerseasons/");
            var result = _request.GetResult<List<AllLeaguesResponse>>();
            _converter = new ResponseConverter();
            return _converter.FromAllLeaguesToLeagues(result);
        }

        public IList<Match> GetMatchesForLeague(League lg)
        {
            _request = new ApiRequest("http://api.football-data.org/v1/soccerseasons/"+lg.ApiId.ToString()+ "/fixtures?timeFrame=p14");
            var result = _request.GetResult<LeaguesMatchesResponse>();
            getConverter();
            return _converter.FromLeaguesMatches(result);
        }

        public Team GetTeam(int? id)
        {
            _request = new ApiRequest("http://api.football-data.org/v1/teams/" + id.ToString() +"/");
            var result = _request.GetResult<TeamResponse>();
            getConverter();
            return _converter.FromTeam(result);
        }

        public IList<Match> GetMatchesForTeam(Team t)
        {
            _request = new ApiRequest("http://api.football-data.org/v1/teams/"+t.ApiId.ToString()+ "/fixtures?timeFrame=p7");
            var result = _request.GetResult<TeamsMatchesResponse>();
            getConverter();
            var prev = _converter.FromTeamsMatches(result);
            _request = new ApiRequest("http://api.football-data.org/v1/teams/" + t.ApiId.ToString() + "/fixtures?timeFrame=n7");
            result = _request.GetResult<TeamsMatchesResponse>();
            return prev.Concat(_converter.FromTeamsMatches(result)).ToList();
        }

        public IList<Player> GetPlayersForTeam(Team ts)
        {
            _request = new ApiRequest("http://api.football-data.org/v1/teams/"+ts.ApiId.ToString()+"/players");
            var result = _request.GetResult<TeamsPlayersResponse>();
            getConverter();
            return _converter.FromTeamsPlayers(result);
        }

        public List<Team> GetTeamsForLeague(League lg)
        {
            _request = new ApiRequest("http://api.football-data.org/v1/soccerseasons/" + lg.ApiId.ToString() + "/teams");
            var result = _request.GetResult<LeaguesTeamsResponse>();
            getConverter();
            return _converter.FromLeaguesTeams(result);
        }

        public League GetLeague(int? id)
        {
            _request = new ApiRequest("http://api.football-data.org/v1/soccerseasons/" + id.ToString() +"/");
            var result = _request.GetResult<LeagueResponse>();
            getConverter();
            return _converter.FromLeague(result);
        }
    }
}
