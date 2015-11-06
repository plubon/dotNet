using System.Collections.Generic;

namespace Model.Enitites
{
    public class Team : NamedModel
    {
        public virtual IList<Player> Players { get; set; }
        public virtual IList<Match> HomeMatches { get; set; }
        public virtual IList<Match> AwayMatches { get; set; }

   
    }
}