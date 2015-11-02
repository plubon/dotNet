using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enitites
{
    public abstract class BaseModel
    {
        public virtual int Id { get; protected set; }
    }
}
