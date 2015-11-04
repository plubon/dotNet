using System.Collections.Generic;

namespace Model.Enitites
{
    public class Player : NamedModel
    {
        public virtual string Nationality { get; set; }
        public virtual IList<Team> Teams { get; set; }
    }
}