using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Model.Enitites;
using Repository;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "http://digitalathletics.azurewebsites.net", headers: "*", methods: "*")]
    [RoutePrefix("api/teams")]
    public class TeamsController : ApiController
    {
        readonly TeamRepository _repository = new TeamRepository();
        [Route("")]
        public IEnumerable<Team> GetTeams()
        {
            var queryResult = _repository.GetAll();
            return queryResult.Select(o => new APITeam(o)).ToList();
        }
        [Route("{id:int}")]
        public IHttpActionResult GetTeam(int id)
        {
            var team = _repository.GetById(id);
            if (team == null)
            {
                return NotFound();
            }
            var result = new APITeam(team);
            return Ok(result);
        }
    }
}
