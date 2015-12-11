using Model.Enitites;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class NamedModelRepository<ModelClass> : AbstractRepository<ModelClass>  where ModelClass:NamedModel 
    {

        public virtual ModelClass GetByName(string name)
        {
            var temp = QueryOverModel().Where(x => x.Name == name).Take(1).SingleOrDefault();
            //_session.Close();
            return temp;
        }

        public bool ContainsName(string name)
        {
            return QueryOverModel().Where(x => x.Name == name).RowCount() > 0;
        }
    }
}
