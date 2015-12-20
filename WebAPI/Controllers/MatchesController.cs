using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model.Enitites;
using Repository;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/matches")]
    public class MatchesController : ApiController
    {
        readonly MatchRepository _repository = new MatchRepository();
        [Route("")]
        public IEnumerable<Match> GetAllMatches()
        {
            var qres = _repository.GetAll();
            return qres.Select(o => new APIMatch(o)).ToList();
        }
        [Route("from/{from:datetime}/to/{to:datetime}")]
        public IEnumerable<Match> GetFromInterval(DateTime from, DateTime to)
        {
            var qres =  _repository.GetFromTimeInterval(from, to);
            return qres.Select(o => new APIMatch(o)).ToList();
        }
        [Route("{id:int}")]
        public IHttpActionResult GetMatch(int id)
        {
            var match = _repository.GetById(id);
            if (match == null)
            {
                return NotFound();
            }

            return Ok(new APIMatch(match));
        }
        
        [Route("team/{id}")]
        public IEnumerable<Match> GetMatchesOfTeam(int id)
        {
            TeamRepository tmp = new TeamRepository();
            var team = tmp.GetById(id);
            var qres = _repository.GetAllMatchesOfTeam(team);
            return qres.Select(o => new APIMatch(o)).ToList();
        }

        [Route("league/{id}")]
        public IEnumerable<Match> GetMatchesOfLeague(int id)
        {
            LeagueRepository tmp = new LeagueRepository();
            var league = tmp.GetById(id);
            var qres = _repository.GetAllMatchesOfLeague(league);
            return qres.Select(o => new APIMatch(o)).ToList();
        } 
    }
}
