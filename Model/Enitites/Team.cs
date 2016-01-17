using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace Model.Enitites
{
    public class Team : NamedModel
    {
        [JsonIgnore]
        public virtual IList<Player> Players { get; set; }
        [JsonIgnore]
        public virtual IList<Match> HomeMatches { get; set; }
        [JsonIgnore]
        public virtual IList<Match> AwayMatches { get; set; }
        [JsonIgnore]
        public virtual Discipline Discipline { get; set; }
        [JsonIgnore]
        public virtual int? ApiId { get; set; }
        public virtual string LogoURI { get; set; }
        [JsonIgnore]
        public virtual DateTime UpdatedAt { get; set; }
        [JsonIgnore]
        public virtual IList<User> FollowedBy { get; set; }
    }
}