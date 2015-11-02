using FluentNHibernate.Mapping;
using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mappings
{
    class DisciplineMapping : ClassMap<Discipline>
    {
        public DisciplineMapping()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Description);
            HasMany(x => x.Teams);
            HasMany(x => x.Leagues);
        }
    }
}
