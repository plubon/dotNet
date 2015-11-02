using System.Collections.Generic;

namespace Model.Enitites
{
    public class Player
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual string Nationality { get; set; }
        public virtual IList<Team> Teams { get; set; }
    }
}