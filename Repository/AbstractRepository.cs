using NHibernate;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enitites;

namespace Repository
{
    public abstract class AbstractRepository<ModelClass> where ModelClass:BaseModel
    {

        private ISessionFactory _session;

        public AbstractRepository()
        {

        }

        protected ISessionFactory getSession()
        {
            return HibernateConfiguration.CreateSessionFactory();
        }

        public ModelClass getById(int id)
        {
            _session = getSession();
            var temp = _session.OpenSession().QueryOver<ModelClass>().Where(x => x.Id == id).SingleOrDefault();
            _session.Dispose();
            return temp;
        }

        public void saveOrUpdate(ModelClass entity)
        {
            _session = getSession();
            _session.OpenSession().SaveOrUpdate(entity);
            _session.Dispose();
        }

        public void delete(ModelClass entity)
        {
            _session = getSession();
            _session.OpenSession().Delete(entity);
            _session.Dispose();
        }
    }
}
