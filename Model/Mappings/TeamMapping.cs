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
            HasManyToMany(x => x.Players)
                .Cascade.All()
                .Table("Players_Teams");
            HasMany(x => x.HomeMatches);
            HasMany(x => x.AwayMatches);
        }
    }
}
