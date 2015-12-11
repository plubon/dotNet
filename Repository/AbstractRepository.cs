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

        protected ISession _session;

        protected void OpenSession()
        {
            if(_session==null)
                _session=HibernateConfiguration.GetSession();
            else if (!_session.IsOpen)
                _session = HibernateConfiguration.GetSession();
        }

        public ITransaction OpenTranscation()
        {
            OpenSession();
            return _session.BeginTransaction();
        }

       public virtual IList<ModelClass> GetAll()
        {
            var temp = QueryOverModel().List();
            //CloseSession();
            return temp;
        }

        protected void CloseSession()
        {
            _session.Close();
        }

        protected NHibernate.IQueryOver<ModelClass, ModelClass> QueryOverModel()
        {
            OpenSession();
            return _session.QueryOver<ModelClass>();
        }


        public IList<ModelClass> GetFromTop(int number, int skip=0)
        {
            var temp=QueryOverModel().Skip(skip).Take(number).List();
            //_session.Close();
            return temp;
        }

        public virtual ModelClass GetById(int id)
        {
            var temp = QueryOverModel().Where(x => x.Id == id).Take(1).SingleOrDefault();
            //_session.Close();
            return temp;
        }

        public void SaveOrUpdate(ModelClass entity)
        {
            OpenSession();
            
            {
                _session.SaveOrUpdate(entity);
                //_session.Flush();
            }
            //_session.Close();
        }

        public void Delete(ModelClass entity)
        {
            OpenSession();
            //using (ITransaction transaction = _session.BeginTransaction())
            {
                _session.Delete(entity);
                //_session.Flush();
            }
            //_session.Close();
        }

        public bool ContainsId(int id)
        {
            return QueryOverModel().Where(x => x.Id == id).RowCount() > 0;
        }
    }
}
