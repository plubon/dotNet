using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PlayerRepository : NamedModelRepository<Player>
    {
        public IList<Player> GetPlayersOfTeam(Team t)
        {
            var temp = QueryOverModel().Where(x => x.Teams == t).List();
            CloseSession();
            return temp;
        }
        public IList<Player> GetPlayersOfTeam(int id)
        {
            var team_repo = new TeamRepository();
            var team = team_repo.GetById(id);
            var temp = QueryOverModel().Where(x => x.Teams.Id == id).List();
            CloseSession();
            return temp;
        }

    }
}
