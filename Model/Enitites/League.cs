using System.Collections.Generic;
using Newtonsoft.Json;

namespace Model.Enitites
{
   
    public class League : NamedModel
    {
        public virtual string Description { get; set; }
        [JsonIgnore]
        public virtual IList<Match> Matches { get; set; }
        [JsonIgnore]
        public virtual Discipline Discipline { get; set; }
        [JsonIgnore]
        public virtual int? ApiId { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}