using System;
namespace Model.Enitites
{
    public class Match
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime Date { get; set; }
        public virtual Team HomeTeam { get; set; }
        public virtual Team AwayTeam { get; set; }
        public virtual int HomeTeamScore { get; set; }
        public virtual int AwayTeamScore { get; set; }
    }
}