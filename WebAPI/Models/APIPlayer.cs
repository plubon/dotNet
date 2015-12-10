using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.Enitites;

namespace WebAPI.Models
{
    public class APIPlayer : Player
    {
        public new virtual int Teams { get; set; }

        public APIPlayer(Player player)
        {
            this.Name = player.Name;
            this.Nationality = player.Nationality;
            this.Teams = player.Teams.Id;
            this.Id = player.Id;
            
        }
    }
}