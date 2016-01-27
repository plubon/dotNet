using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MatchRepository : AbstractRepository<Match>
    {
        public IList<Match> GetAllMatchesOfTeam(Team t)
        {
            var temp = QueryOverModel().Where(x => x.HomeTeam.Id == t.Id || x.AwayTeam.Id == t.Id).List(); //TODO can't call it from API, binary OR error 
            //_session.Close();
            return temp;
        }

        public IList<Match> GetAllMatchesOfTeam(int id)
        {
            var temp = QueryOverModel().Where(x => x.HomeTeam.Id == id || x.AwayTeam.Id == id).List();
            //_session.Close();
            return temp;
        }

        public IList<Match> GetAllMatchesOfTeam(string name)
        {
            var temp = QueryOverModel().Where(x => x.HomeTeam.Name == name || x.AwayTeam.Name == name).List();
            //_session.Close();
            return temp;
        }

        public IList<Match> GetMatchesOfFollowedTeams(User u)
        {
           var trepo = new TeamRepository();
           var ret = new List<Match>();
           foreach(var t in u.FollowedTeams)
           {
                trepo.UpdateMatchesOfTeam(t);
                ret = ret.Concat(GetAllMatchesOfTeam(t)).ToList();
           }
            return ret;
        }

        public IList<Match> GetMatchesOfFollowedTeams(int uid)
        {
            return GetMatchesOfFollowedTeams(new UserRepository().GetById(uid));
        }

        public IList<Match> GetMatchesOfFollowedTeams(string name)
        {
            return GetMatchesOfFollowedTeams(new UserRepository().GetByName(name));
        }

        public IList<Match> GetFromTimeInterval(DateTime start, DateTime end)
        {
            var temp = QueryOverModel().Where(x => x.Date>=start && x.Date<=end).List(); //TODO we've got to fix this, it's not working at all
            //_session.Close();
            return temp;
        }

        public bool ContainsMatch(DateTime date, string n1, string n2)
        {
            return QueryOverModel().Where(x => (x.Date==date) && (x.HomeTeam.Name == n1 || x.AwayTeam.Name == n1) && (x.HomeTeam.Name == n2 || x.AwayTeam.Name == n2)).RowCount() > 0;
        }

        public bool ContainsMatch(Match m)
        {
            return QueryOverModel().Where(x => x.Date == m.Date).JoinQueryOver(x => x.HomeTeam).Where(x => x.Name == m.HomeTeam.Name || x.Name == m.AwayTeam.Name).Take(1).RowCount()>0;
        }

        public IList<Match> GetAllMatchesOfLeague(League league)
        {
            var temp = QueryOverModel().Where(x => x.League.Id == league.Id).List(); 
            //_session.Close();
            return temp;
        }

        public Match GetMatch(Match m)
        {
            return QueryOverModel().Where(x => x.Date == m.Date).JoinQueryOver(x => x.HomeTeam).Where(x => x.Name == m.HomeTeam.Name || x.Name == m.AwayTeam.Name).Take(1).SingleOrDefault();
        }

    }
}
