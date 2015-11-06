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
            References(x => x.HomeTeam).Nullable();
            References(x => x.AwayTeam).Nullable();
            References(x => x.League).Cascade.Delete();
        }
    }
}
