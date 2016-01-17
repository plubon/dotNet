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
            Id(x => x.UserId);
            Map(x => x.UserName).Unique();
            Map(x => x.PasswordHash);
            Map(x => x.SecurityStamp);
        }
    }
}
