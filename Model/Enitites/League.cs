using System.Collections.Generic;

namespace Model.Enitites
{
    public class League : NamedModel
    {
        public virtual string Description { get; set; }
        public virtual IList<Match> Matches { get; set; }
        public virtual Discipline Discipline { get; set; }
    }
}