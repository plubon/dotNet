using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class LeagueRepository : NamedModelRepository<League>
    {
        public IList<League> GetByDiscipline(Discipline d)
        {
            var temp = QueryOverModel().Where(x => x.Discipline == d).List();
            CloseSession();
            return temp;
        }

        public IList<League> GetByDiscipline(int id)
        {
            var temp = QueryOverModel().Where(x => x.Discipline.Id == id).List();
            CloseSession();
            return temp;
        }

        public IList<League> GetByDiscipline(string name)
        {
            var temp = QueryOverModel().Where(x => x.Discipline.Name == name).List();
            CloseSession();
            return temp;
        }
    }
}
