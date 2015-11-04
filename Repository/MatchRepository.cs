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
        public IList<Match> getAllMatchesOfTeam(Team t)
        {
            var temp = queryOverModel().Where(x => x.HomeTeam.Id == t.Id | x.AwayTeam.Id == t.Id).List();
            _session.Dispose();
            return temp;
        }

        public IList<Match> getAllMatchesOfTeam(int id)
        {
            var temp = queryOverModel().Where(x => x.HomeTeam.Id == id | x.AwayTeam.Id == id).List();
            _session.Dispose();
            return temp;
        }

        public IList<Match> getAllMatchesOfTeam(string name)
        {
            var temp = queryOverModel().Where(x => x.HomeTeam.Name == name | x.AwayTeam.Name == name).List();
            _session.Dispose();
            return temp;
        }
    }
}
