using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DisciplineRepository : NamedModelRepository<Discipline>
    {
        public  Discipline GetByName(string name)
        {
            var temp = QueryOverModel().Where(x => x.Name == name).SingleOrDefault();
            _session.Close();
            return temp;
        }
    }
}
