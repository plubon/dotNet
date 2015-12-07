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
    [RoutePrefix("api/teams")]
    public class TeamsController : ApiController
    {
        TeamRepository _repository = new TeamRepository();
        [Route("")]
        public IEnumerable<Team> GetTeams()
        {
            return _repository.GetAll();
        }
        [Route("{id:int}")]
        public IHttpActionResult GetTeam(int id)
        {
            var team = _repository.GetById(id);
            if (team == null)
            {
                return NotFound();
            }
            return Ok(team);
        }
    }
}
