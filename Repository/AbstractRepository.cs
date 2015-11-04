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

        protected ISessionFactory _session;

        protected ISessionFactory getSession()
        {
            return HibernateConfiguration.CreateSessionFactory();
        }

        protected NHibernate.IQueryOver<ModelClass, ModelClass> queryOverModel()
        {
            _session = getSession();
            return _session.OpenSession().QueryOver<ModelClass>();
        }


        public IList<ModelClass> getFromTop(int number, int skip=0)
        {
            var temp=queryOverModel().Skip(skip).Take(number).List();
            _session.Dispose();
            return temp;
        }

        public ModelClass getById(int id)
        {
            var temp = queryOverModel().Where(x => x.Id == id).SingleOrDefault();
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
