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
    [EnableCors(origins: "http://digitalathletics.azurewebsites.net , http://localhost:17197", headers: "*", methods: "*")]
    [RoutePrefix("api/follows")]
    public class FollowController : ApiController
    {
        [HttpPost]
        [Route("follow")]
        public IHttpActionResult Follow()
        {
            var uId = Int32.Parse(HttpContext.Current.Request.Form.GetValues("userId").FirstOrDefault());
            var tId = Int32.Parse(HttpContext.Current.Request.Form.GetValues("teamId").FirstOrDefault());
            var uRepo = new UserRepository();
            var tRepo = new TeamRepository();
            if (!(uRepo.ContainsId(uId) && tRepo.ContainsId(tId)))
                return NotFound();
            var u = uRepo.GetById(uId);
            var t = tRepo.GetById(tId);
            u.FollowedTeams.Add(t);
            uRepo.SaveOrUpdate(u);
            return Ok();
        }
        [Route("unfollow")]
        public IHttpActionResult UnFollow()
        {
            var uId = Int32.Parse(HttpContext.Current.Request.Form.GetValues("userId").FirstOrDefault());
            var tId = Int32.Parse(HttpContext.Current.Request.Form.GetValues("teamId").FirstOrDefault());
            var uRepo = new UserRepository();
            var tRepo = new TeamRepository();
            if (!(uRepo.ContainsId(uId) && tRepo.ContainsId(tId)))
                return NotFound();
            var u = uRepo.GetById(uId);
            var t = tRepo.GetById(tId);
            if (u.FollowedTeams.Contains(t))
                u.FollowedTeams.Remove(t);
            uRepo.SaveOrUpdate(u);
            return Ok();
        }
    }
}
