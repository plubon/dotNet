using FluentNHibernate.Mapping;
using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mappings
{
    class TeamMapping : ClassMap<Team>
    {
        public TeamMapping()
        {
            Id(x => x.Id);
            Map(x => x.Name).Unique();
            HasMany(x => x.Players);
            HasMany(x => x.HomeMatches);
            HasMany(x => x.AwayMatches);
            References(x => x.Discipline);
            Map(x => x.ApiId).Nullable();
            Map(x => x.LogoURI).Nullable();
        }
    }
}
