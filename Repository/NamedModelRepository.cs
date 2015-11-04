using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class NamedModelRepository<ModelClass> : AbstractRepository<ModelClass>  where ModelClass:NamedModel 
    {
        ModelClass GetByName(string name)
        {
            var temp = QueryOverModel().Where(x => x.Name.Equals(name)).SingleOrDefault();
            _session.Close();
            return temp;
        }
    }
}
