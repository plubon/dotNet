﻿using System;
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
    [EnableCors(origins: "http://digitalathletics.azurewebsites.net , http://localhost:17197", headers: "*", methods: "*")]
    [RoutePrefix("api/players")]
    public class PlayersController : ApiController
    {
        PlayerRepository _repository = new PlayerRepository();
        [Route("")]
        public IEnumerable<Player> GetPlayers()
        {
            var qresult =  _repository.GetAll();
            return qresult.Select(x => new APIPlayer(x)).ToList();
        }
        [Route("{id:int}")]
        public IHttpActionResult GetPlayer(int id)
        {
            var player = _repository.GetById(id);
            if (player == null)
            {
                return NotFound();
            }

            return Ok(new APIPlayer(player));
        }

        [Route("team/{id:int}")]
        public IEnumerable<Player> GetPlayersOfTeam(int id)
        {
            var qres =  _repository.GetPlayersOfTeam(id);
            return qres.Select(x => new APIPlayer(x)).ToList();
        } 

    }
}
