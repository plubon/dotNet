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
    [RoutePrefix("api/leagues")]
    public class LeaguesController : ApiController
    {
        readonly LeagueRepository _repository = new LeagueRepository();
        [Route("")]
        public IEnumerable<League> GetAllLeagues()
        {
            var queryResult = _repository.GetAll();
            return queryResult.Select(o => new APILeague(o)).ToList();
        }
        [Route("{id:int}")]
        public IHttpActionResult GetLeague(int id)
        {
            var league = _repository.GetById(id);
            if (league == null)
            {
                return NotFound();
            }
            var result = new APILeague(league);
            return Ok(result);
        }
        [Route("discipline/{id:int}")]
        public IEnumerable<League> GetLeaguesByDiscipline(int id)
        {
            DisciplineRepository _rep = new DisciplineRepository();
            Discipline _discipline = _rep.GetById(id);
            if (_discipline!=null)
            {
                var qresult = _repository.GetByDiscipline(_discipline);
                return qresult.Select(o => new APILeague(o)).ToList();
            }
            return null;
        } 
    }
}
