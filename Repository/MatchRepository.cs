﻿using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MatchRepository : AbstractRepository<Match>
    {
        public IList<Match> GetAllMatchesOfTeam(Team t)
        {
            var temp = QueryOverModel().Where(x => x.HomeTeam.Id == t.Id | x.AwayTeam.Id == t.Id).List(); //TODO can't call it from API, binary OR error 
            _session.Close();
            return temp;
        }

        public IList<Match> GetAllMatchesOfTeam(int id)
        {
            var temp = QueryOverModel().Where(x => x.HomeTeam.Id == id | x.AwayTeam.Id == id).List();
            _session.Close();
            return temp;
        }

        public IList<Match> GetAllMatchesOfTeam(string name)
        {
            var temp = QueryOverModel().Where(x => x.HomeTeam.Name == name | x.AwayTeam.Name == name).List();
            _session.Close();
            return temp;
        }

        public IList<Match> GetFromTimeInterval(DateTime start, DateTime end)
        {
            var temp = QueryOverModel().Where(x => x.Date>=start && x.Date<=end).List(); //TODO we've got to fix this, it's not working at all
            _session.Close();
            return temp;
        }
    }
}
