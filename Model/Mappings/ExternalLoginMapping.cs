using FluentNHibernate.Mapping;
using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mappings
{
    class ExternalLoginMapping : ClassMap<ExternalLogins>
    {
        public ExternalLoginMapping()
        {
            Id(x => x.Id);
            References(x => x.UserId);
            Map(x => x.LoginProvider);
            Map(x => x.ProviderKey);
        }
    }
}
