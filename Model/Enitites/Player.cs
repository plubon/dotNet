using System.Collections.Generic;

namespace Model.Enitites
{
    public class Player : NamedModel
    {
        public virtual string Nationality { get; set; }
        public virtual Team Teams { get; set; }
    }
}