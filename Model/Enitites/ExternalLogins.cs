using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enitites
{
    public class ExternalLogins : BaseModel
    {
        public virtual User UserId { get; set; }
        public virtual string LoginProvider { get; set; }
        public virtual string ProviderKey { get; set; } 
    }
}
