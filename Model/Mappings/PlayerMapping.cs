using FluentNHibernate.Mapping;
using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mappings
{
    class PlayerMapping : ClassMap<Player>
    {
        public PlayerMapping()
        {
            Id(x => x.Id);
            Map(x => x.Name).Unique();
            Map(x => x.Nationality);
            References(x => x.Teams).Nullable();
        }
    }
}
