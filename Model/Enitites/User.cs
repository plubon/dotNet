using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enitites
{
    public class User : NamedModel
    {
        public virtual string PasswordHash { get; set; }
        public virtual string SecurityStamp { get; set; }
        public virtual IList<Team> FollowedTeams { get; set; }
        public virtual IList<Bet> Bets { get; set; }
    }
}
