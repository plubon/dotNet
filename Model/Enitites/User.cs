using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enitites
{
    public class User : IUser
    {
        public virtual string UserName { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual string SecurityStamp { get; set; }
        public virtual int UserId { get; protected set; }

        public virtual string Id
        {
            get { return UserId.ToString(); }
        }
    }
}
