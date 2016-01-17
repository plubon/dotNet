using FluentNHibernate.Mapping;
using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mappings
{
    class BetMapping : ClassMap<Bet>
    {
        public BetMapping()
        {
            Id(x => x.Id);
            References(x => x.Match);
            References(x => x.User);
            Map(x => x.AwayTeamScore);
            Map(x => x.HomeTeamScore);
        }
    }
}
