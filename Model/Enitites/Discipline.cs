using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enitites
{
    public class Discipline : NamedModel
    {
        public virtual string Description { get; set; }
        public virtual IList<League> Leagues { get; set; }
        public virtual IList<Team> Teams { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
