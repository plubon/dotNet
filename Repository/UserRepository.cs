using Microsoft.AspNet.Identity;
using Model;
using Model.Enitites;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : IUserStore<User>, IUserPasswordStore<User>, IUserSecurityStampStore<User>, IUserLoginStore<User>
    {
        protected ISession _session;

        protected void OpenSession()
        {
            if (_session == null)
                _session = HibernateConfiguration.GetSession();
            else if (!_session.IsOpen)
                _session = HibernateConfiguration.GetSession();
        }

        public virtual Task CreateAsync(User user)
        {
            return new Task(() => { SaveOrUpdate(user); });
        }

        public virtual Task UpdateAsync(User user)
        {
            return CreateAsync(user);
        }

        public virtual Task DeleteAsync(User user)
        {
            return new Task(() => { Delete(user); });
        }

        public virtual Task<User> FindByIdAsync(string userId)
        {
            return new Task<User>(() => GetById(Int32.Parse(userId)));
        }

        public virtual Task<User> FindByNameAsync(string name)
        {
            return new Task<User>(() => GetByName(name));
        }

        public User GetByName(string name)
        {
            var temp = QueryOverModel().Where(x => x.UserName == name).Take(1).SingleOrDefault();
            //_session.Close();
            return temp;
        }

        public ITransaction OpenTranscation()
        {
            OpenSession();
            return _session.BeginTransaction();
        }

        public virtual IList<User> GetAll()
        {
            var temp = QueryOverModel().List();
            //CloseSession();
            return temp;
        }

        protected void CloseSession()
        {
            _session.Close();
        }

        protected NHibernate.IQueryOver<User, User> QueryOverModel()
        {
            OpenSession();
            return _session.QueryOver<User>();
        }


        public IList<User> GetFromTop(int number, int skip = 0)
        {
            var temp = QueryOverModel().Skip(skip).Take(number).List();
            //_session.Close();
            return temp;
        }

        public virtual User GetById(int id)
        {
            var temp = QueryOverModel().Where(x => x.UserId == id).Take(1).SingleOrDefault();
            //_session.Close();
            return temp;
        }

        public void SaveOrUpdate(User entity)
        {
            OpenSession();

            {
                try
                {
                    _session.SaveOrUpdate(entity);
                }
                catch (Exception e)
                {

                }
                //_session.Flush();
            }
            //_session.Close();
        }

        public void Delete(User entity)
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
            return QueryOverModel().Where(x => x.UserId == id).RowCount() > 0;
        }

        public void Dispose()
        {

        }

        public virtual Task<string> GetPasswordHashAsync(User user)
        {
            return Task.FromResult(user.PasswordHash);
        }

        public virtual Task<bool> HasPasswordAsync(User user)
        {
            return Task.FromResult(!string.IsNullOrEmpty(user.PasswordHash));
        }

        public virtual Task SetPasswordHashAsync(User user, string passwordHash)
        {
            user.PasswordHash = passwordHash;
            SaveOrUpdate(user);
            return Task.FromResult(0);
        }

        public virtual Task<string> GetSecurityStampAsync(User user)
        {
            return Task.FromResult(user.SecurityStamp);
        }

        public virtual Task SetSecurityStampAsync(User user, string stamp)
        {
            user.SecurityStamp = stamp;
            SaveOrUpdate(user);
            return Task.FromResult(0);
        }
        public virtual Task AddLoginAsync(User user, UserLoginInfo login)
        {
            return Task.FromResult(0);
        }

        public virtual Task<User> FindAsync(UserLoginInfo login)
        {
            return null;
        }

        public virtual Task<IList<UserLoginInfo>> GetLoginsAsync(User user)
        {
            return null;
        }

        public virtual Task RemoveLoginAsync(User user, UserLoginInfo login)
        {
            return null;
        }
    }
}
