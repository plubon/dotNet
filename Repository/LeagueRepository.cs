using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballDataAPI;

namespace Repository
{
    public class LeagueRepository : NamedModelRepository<League>
    {
        FootballAPIClient _client;
        public IList<League> GetByDiscipline(Discipline d)
        {
            if (d.Name=="Football")
                GetAllLeaguesFromApi();
            var temp = QueryOverModel().Where(x => x.Discipline == d).List();
            //CloseSession();
            return temp;
        }

        private void GetApiClient()
        {
            if (_client == null)
                _client = new FootballAPIClient();
        }

        private void GetAllLeaguesFromApi()
        {
            GetApiClient();
            var leagues = _client.GetAllLeagues();
            var discipline = new DisciplineRepository().GetByName("Football");
            foreach( var league in leagues)
            {
                if (!ContainsName(league.Name))
                {
                    league.Discipline = discipline;
                    SaveOrUpdate(league);
                }
            }
        }


        public IList<League> GetByDiscipline(int id)
        {
            if (new DisciplineRepository().GetById(id).Name=="Football")
                GetAllLeaguesFromApi();
            var temp = QueryOverModel().Where(x => x.Discipline.Id == id).List();
            //CloseSession();
            return temp;
        }

        public League GetByApiId(int? id)
        {
            if (QueryOverModel().Where(x => x.ApiId == id).RowCount() > 0)
                return QueryOverModel().Where(x => x.ApiId == id).Take(1).SingleOrDefault();
            else
            {
                League lg = getFromApiById(id);
                SaveOrUpdate(lg);
                return lg;
            }

        }

        private League getFromApiById(int? id)
        {
            GetApiClient();
            var league = _client.GetLeague(id);
            return league;
        }

        public IList<League> GetByDiscipline(string name)
        {
            if (name == "Football")
                GetAllLeaguesFromApi();
            var temp = QueryOverModel().JoinQueryOver(x => x.Discipline).Where(y =>y.Name=="Football").List();
            //CloseSession();
            return temp;
        }

        public override IList<League> GetAll()
        {
            GetAllLeaguesFromApi();
            var temp = QueryOverModel().Take(20).List();
            //CloseSession();
            return temp;
        }

        public override League GetById(int id)
        {
            var temp = QueryOverModel().Where(x => x.Id == id).Take(1).SingleOrDefault();
            if (temp.Discipline.Name == "Football")
            {
                UpdateLeagueFromApi(temp);
                SaveOrUpdate(temp);
            }
            //_session.Close();
            return temp;
        }

        private void UpdateLeagueFromApi(League lg)
        {
            if (lg.ApiId != null)
            {
                GetTeamsOfLeagueFromApi(lg);
                GetMatchesOfLeagueFromApi(lg);
            }
        }

        private void GetMatchesOfLeagueFromApi(League lg)
        {
            GetApiClient();
            var matches = _client.GetMatchesForLeague(lg);
            var repo = new TeamRepository();
            var mrepo = new MatchRepository();
            using (var trans = mrepo.OpenTranscation())
            {
                foreach (var m in matches)
                {
                    if (!mrepo.ContainsMatch(m))
                    {
                        m.League = lg;
                        m.HomeTeam = repo.GetByName(m.HomeTeam.Name);
                        m.AwayTeam = repo.GetByName(m.AwayTeam.Name);
                        mrepo.SaveOrUpdate(m);
                    }
                    else
                    {
                        var oldMatch = mrepo.GetMatch(m);
                        if (oldMatch.AwayTeamScore != m.AwayTeamScore)
                        {
                            oldMatch.AwayTeamScore = m.AwayTeamScore;
                            oldMatch.HomeTeamScore = m.HomeTeamScore;
                            mrepo.SaveOrUpdate(oldMatch);
                        }
                    }
                }
                trans.Commit();
            }
        }

        private void GetTeamsOfLeagueFromApi(League lg)
        {
            GetApiClient();
            var teams = _client.GetTeamsForLeague(lg);
            var discipline = new DisciplineRepository().GetByName("Football");
            var repo = new TeamRepository();
            foreach (var t in teams)
            {
                if(!repo.ContainsName(t.Name))
                {
                    t.Discipline = discipline;
                    repo.SaveOrUpdate(t);
                }
            }
        }
    }
}
