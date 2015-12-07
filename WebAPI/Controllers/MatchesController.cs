using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model.Enitites;
using Repository;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/matches")]
    public class MatchesController : ApiController
    {
        readonly MatchRepository _repository = new MatchRepository();
        [Route("")]
        public IEnumerable<Match> GetAllMatches()
        {
            return _repository.GetAll();
        }
        [Route("from/{from:datetime}/to/{to:datetime}")]
        public IEnumerable<Match> GetFromInterval(DateTime from, DateTime to)
        {
            return _repository.GetFromTimeInterval(from, to);
        }
        [Route("{id:int}")]
        public IHttpActionResult GetMatch(int id)
        {
            var match = _repository.GetById(id);
            if (match == null)
            {
                return NotFound();
            }
            return Ok(match);
        }
        [Route("team/{id}")]
        public IEnumerable<Match> GetMatchesOfTeam(int id)
        {
            return _repository.GetAllMatchesOfTeam(id);
        }

        
            
        
    }
}
