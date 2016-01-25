using FluentNHibernate.Mapping;
using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mappings
{
    class UserMapping : ClassMap<User>
    {
        public UserMapping()
        {
            Id(x => x.Id);
            Map(x => x.Name).Unique();
            Map(x => x.PasswordHash);
            Map(x => x.SecurityStamp);
            HasMany(x => x.Bets);
            HasManyToMany(x => x.FollowedTeams);
        }
    }
}
