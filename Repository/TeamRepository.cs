using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TeamRepository : NamedModelRepository<Team>
    {
        public IList<Team> GetTeamsOfPlayer(Player p)
        {
            var temp = QueryOverModel().Where(x => x.Players.Contains(p)).List();
            CloseSession();
            return temp;
        }

        public IList<Team> GetTeamsOfPlayer(int id)
        {
            var temp = QueryOverModel().Where(x => x.Players.All(r => r.Id==id)).List();
            CloseSession();
            return temp;
        }

        public IList<Team> GetTeamsOfPlayer(string name)
        {
            var temp = QueryOverModel().Where(x => x.Players.All(r => r.Name == name)).List();
            CloseSession();
            return temp;
        }
    }
}
