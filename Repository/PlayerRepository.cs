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
            var temp = QueryOverModel().Where(x => x.Teams.Contains(t)).List();
            CloseSession();
            return temp;
        }

        public IList<Player> GetTeamsOfPlayer(int id)
        {
            var temp = QueryOverModel().Where(x => x.Teams.All(r => r.Id == id)).List();
            CloseSession();
            return temp;
        }

        public IList<Player> GetTeamsOfPlayer(string name)
        {
            var temp = QueryOverModel().Where(x => x.Teams.All(r => r.Name == name)).List();
            CloseSession();
            return temp;
        }
    }
}
