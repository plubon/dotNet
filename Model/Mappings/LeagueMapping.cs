using FluentNHibernate.Mapping;
using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mappings
{
    class LeagueMapping : ClassMap<League>
    {
        public LeagueMapping()
        {
            Id(x => x.Id);
            Map(x => x.Name).Unique();
            Map(x => x.Description);
            HasMany(x => x.Matches);
            References(x => x.Discipline).Cascade.Delete();
            Map(x => x.ApiId).Nullable();
            Map(x => x.UpdatedAt).Nullable();
        }
    }
}
