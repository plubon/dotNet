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
    [RoutePrefix("api/players")]
    public class PlayersController : ApiController
    {
        PlayerRepository _repository = new PlayerRepository();
        [Route("")]
        public IEnumerable<Player> GetPlayers()
        {
            return _repository.GetAll();
        }
        [Route("{id:int}")]
        public IHttpActionResult GetPlayer(int id)
        {
            var player = _repository.GetById(id);
            if (player == null)
            {
                return NotFound();
            }
            return Ok(player);
        }

        [Route("team/{id:int}")]
        public IEnumerable<Player> GetPlayersOfTeam(int id)
        {
            return _repository.GetPlayersOfTeam(id);
        } 

    }
}
