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
        ModelClass getByName(string name)
        {
            var temp = queryOverModel().Where(x => x.Name.Equals(name)).SingleOrDefault();
            _session.Dispose();
            return temp;
        }
    }
}
