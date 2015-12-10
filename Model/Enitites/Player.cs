using System.Collections.Generic;
using Newtonsoft.Json;

namespace Model.Enitites
{
    public class Player : NamedModel
    {
        public virtual string Nationality { get; set; }
        [JsonIgnore]
        public virtual Team Teams { get; set; }
    }
}