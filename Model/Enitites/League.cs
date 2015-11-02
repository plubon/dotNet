using System.Collections.Generic;

namespace Model.Enitites
{
    public class League : BaseModel
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual IList<Match> Matches { get; set; }
        public virtual Discipline Discipline { get; set; }
    }
}