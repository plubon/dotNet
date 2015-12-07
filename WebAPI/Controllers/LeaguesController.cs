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
    [RoutePrefix("api/leagues")]
    public class LeaguesController : ApiController
    {
        readonly LeagueRepository _repository = new LeagueRepository();
        [Route("")]
        public IEnumerable<League> GetAllLeagues()
        {
            return _repository.GetAll();
        }
        [Route("{id:int}")]
        public IHttpActionResult GetLeague(int id)
        {
            var league = _repository.GetById(id);
            if (league == null)
            {
                return NotFound();
            }
            return Ok(league);
        }
        [Route("{discipline}")]
        public IEnumerable<League> GetLeaguesByDiscipline(string discipline)
        {
            DisciplineRepository _rep = new DisciplineRepository();
            Discipline _discipline = _rep.GetByName(discipline);
            return _repository.GetByDiscipline(_discipline);
        } 
    }
}
