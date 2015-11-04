using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class MatchRepository : AbstractRepository<Match>
    {
        public IList<Match> GetAllMatchesOfTeam(Team t)
        {
            var temp = QueryOverModel().Where(x => x.HomeTeam.Id == t.Id | x.AwayTeam.Id == t.Id).List();
            _session.Close();
            return temp;
        }

        public IList<Match> GetAllMatchesOfTeam(int id)
        {
            var temp = QueryOverModel().Where(x => x.HomeTeam.Id == id | x.AwayTeam.Id == id).List();
            _session.Close();
            return temp;
        }

        public IList<Match> GetAllMatchesOfTeam(string name)
        {
            var temp = QueryOverModel().Where(x => x.HomeTeam.Name == name | x.AwayTeam.Name == name).List();
            _session.Close();
            return temp;
        }

        public IList<Match> GetFromTimeInterval(DateTime start, DateTime end)
        {
            var temp = QueryOverModel().Where(x => x.Date.CompareTo(start) > 0 & x.Date.CompareTo(end) <0).List();
            _session.Close();
            return temp;
        }
    }
}
