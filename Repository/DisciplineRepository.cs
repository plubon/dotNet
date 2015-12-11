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
        public override Discipline GetByName(string name)
        {
            var temp = QueryOverModel().Where(x => x.Name == name).Take(1).SingleOrDefault();
            //_session.Close();
            return temp;
        }
    }
}
