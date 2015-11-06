using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enitites
{
    public abstract class NamedModel : BaseModel
    {
        public virtual string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
