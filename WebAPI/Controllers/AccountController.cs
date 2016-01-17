using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Repository;
using Microsoft.AspNet.Identity;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/accounts")]
    public class AccountController : ApiController
    {
        [HttpPost]
        [Route("")]
        public HttpResponseMessage Validate(string username, string password)
        {
            var u = new UserRepository();
            var user = u.GetByName(username);
            if (u == null)
                return Request.CreateResponse(HttpStatusCode.Forbidden, "");
            if (new PasswordHasher().VerifyHashedPassword(user.PasswordHash, password)>0)
                return Request.CreateResponse(HttpStatusCode.OK, "fzfjt9gxt3");
            else
                return Request.CreateResponse(HttpStatusCode.Forbidden, "");
        }
    }
}
