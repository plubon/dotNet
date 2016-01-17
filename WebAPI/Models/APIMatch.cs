using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.Enitites;

namespace WebAPI.Models
{
    public class APIMatch : Match
    {
        public new virtual int HomeTeam { get; set; }
        public new virtual int AwayTeam { get; set; }
        public new virtual int League { get; set; }
        public APIMatch(Match match)
        {
            this.Id = match.Id;
            this.Date = match.Date;
            if (match.HomeTeam != null) this.HomeTeam = match.HomeTeam.Id;
            if (match.AwayTeam != null) this.AwayTeam = match.AwayTeam.Id;
            this.HomeTeamScore = match.HomeTeamScore;
            this.AwayTeamScore = match.AwayTeamScore;
            if (match.League != null) this.League = match.League.Id;

        }
    }
}