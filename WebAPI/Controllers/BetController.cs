using Model.Enitites;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "http://digitalathletics.azurewebsites.net", headers: "*", methods: "*")]
    [RoutePrefix("api/bets")]
    public class BetController : ApiController
    {
        [HttpPost]
        [Route("")]
        public IHttpActionResult Bet([FromBody]dynamic value)
        {
            var uId = Int32.Parse(HttpContext.Current.Request.Form.GetValues("userId").FirstOrDefault());
            var mId = Int32.Parse(HttpContext.Current.Request.Form.GetValues("matchId").FirstOrDefault());
            var homeScore = Int32.Parse(HttpContext.Current.Request.Form.GetValues("homeScore").FirstOrDefault());
            var awayScore = Int32.Parse(HttpContext.Current.Request.Form.GetValues("awayScore").FirstOrDefault());
            var mRepo = new MatchRepository();
            if (!mRepo.ContainsId(mId))
                return NotFound();
            var uRepo = new UserRepository();
            if (!uRepo.ContainsId(uId))
                return NotFound();
            var brepo = new BetRepository();
            if (brepo.ContainsBet(mId, uId))
            {
                var b = brepo.GetByMatchAndUserIds(mId, uId);
                b.HomeTeamScore = homeScore;
                b.AwayTeamScore = awayScore;
                brepo.SaveOrUpdate(b);
            }
            else
            {
                var b = new Bet();
                b.AwayTeamScore = awayScore;
                b.HomeTeamScore = homeScore;
                b.Match = mRepo.GetById(mId);
                b.User = uRepo.GetById(uId);
                brepo.SaveOrUpdate(b);
            }
            return Ok();
        }
    }
}
