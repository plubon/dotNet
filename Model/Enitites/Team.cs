using System.Collections.Generic;

namespace Model.Enitites
{
    public class Team
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual IList<Player> Players { get; set; }
        public virtual IList<Match> HomeMatches { get; set; }
        public virtual IList<Match> AwayMatches { get; set; }
    }
}