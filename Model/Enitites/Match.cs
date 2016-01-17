using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Model.Enitites
{
    public class Match : BaseModel
    {
        public virtual DateTime Date { get; set; }
        public virtual Team HomeTeam { get; set; }
        public virtual Team AwayTeam { get; set; }
        public virtual int? HomeTeamScore { get; set; }
        public virtual int? AwayTeamScore { get; set; }
        [JsonIgnore]
        public virtual int ApiId { get; set; }
        public virtual League League { get; set; }
        [JsonIgnore]
        public virtual IList<Bet> Bets { get; set; }
    }
}