using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.Enitites;

namespace WebAPI.Models
{
    public class APITeam : Team
    {
        public new virtual int Discipline { get; set; }
        public APITeam(Team team)
        {
            this.Id = team.Id;
            this.Name = team.Name;
            this.Discipline = team.Discipline.Id;
            this.LogoURI = team.LogoURI;
        }
    }
}