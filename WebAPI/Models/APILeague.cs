using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.Enitites;

namespace WebAPI.Models
{
    public class APILeague : League
    {
        public new virtual int Discipline { get; set; }

        public APILeague(League league)
        {
            this.Name = league.Name;
            this.Description = league.Description;
            this.Id = league.Id;
            this.Matches = league.Matches;
            this.Discipline = league.Discipline != null && league.Discipline.Id>0?league.Discipline.Id:-1;
            
        }
    }
}