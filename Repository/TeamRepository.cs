using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballDataAPI;

namespace Repository
{
    public class TeamRepository : NamedModelRepository<Team>
    {
        FootballAPIClient _client;
        public override Team GetById(int id)
        {
            var temp = QueryOverModel().Where(x => x.Id == id).Take(1).SingleOrDefault();
            if(temp.Discipline.Name=="Football")
            {
                UpdateTeamFromApi(temp);
            }
            return temp;
        }

        public Team GetByApiId(int id)
        {
            if (QueryOverModel().Where(x => x.ApiId == id).RowCount() > 0)
                return QueryOverModel().Where(x => x.ApiId == id).Take(1).SingleOrDefault();
            else
            {
                Team t = getFromApiById(id);
                SaveOrUpdate(t);
                return t;
            }
        }

        private Team getFromApiById(int? id)
        {
            GetApiClient();
            var t = _client.GetTeam(id);
            return t;
        }

        private void UpdateTeamFromApi(Team t)
        {
            if (t.ApiId != null)
            {
                UpdatePlayersOfTeam(t);
                UpdateMatchesOfTeam(t);
            }
        }

        private void UpdateMatchesOfTeam(Team t)
        {

            GetApiClient();
            var mrepo = new MatchRepository();
            var lrepo = new LeagueRepository();
            var matches = _client.GetMatchesForTeam(t);
            foreach(var m in matches)
            {
                if(!mrepo.ContainsMatch(m))
                {
                    m.League = lrepo.GetByApiId(m.League.ApiId);
                    if (DateTime.Compare(t.UpdatedAt, m.League.UpdatedAt) <= 0)
                    {
                        if (m.HomeTeam.Name == t.Name)
                        {
                            m.HomeTeam = t;
                            var team = getFromApiById(m.AwayTeam.ApiId);
                            if (team.Discipline == null)
                                team.Discipline = new DisciplineRepository().GetByName("Football");
                            if (!ContainsName(team.Name))
                                SaveOrUpdate(team);
                            else
                                team = GetByName(team.Name);
                            m.AwayTeam = team;
                        }
                        else
                        {
                            var team = getFromApiById(m.HomeTeam.ApiId);
                            if (team.Discipline == null)
                                team.Discipline = new DisciplineRepository().GetByName("Football");
                            if (!ContainsName(team.Name))
                                SaveOrUpdate(team);
                            else
                                team = GetByName(team.Name);
                            m.HomeTeam = team;
                            m.AwayTeam = t;
                        }
                        mrepo.SaveOrUpdate(m);
                    }
                }
                else
                {
                    var oldMatch = mrepo.GetMatch(m);
                    oldMatch.AwayTeamScore = m.AwayTeamScore;
                    oldMatch.HomeTeamScore = m.HomeTeamScore;
                    mrepo.SaveOrUpdate(oldMatch);
                }
            }
            t.UpdatedAt = DateTime.Now;
            SaveOrUpdate(t);
        }

        private void UpdatePlayersOfTeam(Team t)
        {
            if (t.Players.Count == 0)
            {
                GetApiClient();
                var players = _client.GetPlayersForTeam(t);
                var repo = new PlayerRepository();
                foreach (var p in players)
                {
                    p.Teams = t;
                    if (!repo.ContainsName(p.Name))
                        repo.SaveOrUpdate(p);
                }
                SaveOrUpdate(t);
            }
        }

        public IList<Team> GetTeamsOfPlayer(Player p)
        {
            var temp = QueryOverModel().Where(x => x.Players.Contains(p)).List();
            //CloseSession();
            return temp;
        }

        public IList<Team> GetTeamsOfPlayer(int id)
        {
            var temp = QueryOverModel().Where(x => x.Players.All(r => r.Id==id)).List();
           // CloseSession();
            return temp;
        }

        public IList<Team> GetTeamsOfPlayer(string name)
        {
            var temp = QueryOverModel().Where(x => x.Players.All(r => r.Name == name)).List();
           // CloseSession();
            return temp;
        }

        private void GetApiClient()
        {
            if (_client == null)
                _client = new FootballAPIClient();
        }
    }
}
