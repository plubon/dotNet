using FluentNHibernate.Mapping;
using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mappings
{
    class MatchMapping : ClassMap<Match>
    {
        public MatchMapping()
        {
            Id(x => x.Id);
            Map(x => x.Date);
            Map(x => x.HomeTeamScore);
            Map(x => x.AwayTeamScore);
            References(x => x.HomeTeam);
            References(x => x.AwayTeam);
            References(x => x.League);
        }
    }
}
