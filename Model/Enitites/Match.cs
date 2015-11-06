using System;
namespace Model.Enitites
{
    public class Match : BaseModel
    {
        public virtual DateTime Date { get; set; }
        public virtual Team HomeTeam { get; set; }
        public virtual Team AwayTeam { get; set; }
        public virtual int HomeTeamScore { get; set; }
        public virtual int AwayTeamScore { get; set; }
        public virtual League League { get; set; }
    }
}