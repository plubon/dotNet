using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Repository;
using Microsoft.AspNet.Identity;
using System.Web;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "http://digitalathletics.azurewebsites.net , http://localhost:17197", headers: "*", methods: "*")]
    [RoutePrefix("api/accounts")]
    public class AccountController : ApiController
    {
        [HttpPost]
        [Route("")]
        public HttpResponseMessage Validate([FromBody]dynamic value)
        {
            var username = HttpContext.Current.Request.Form.GetValues("username").FirstOrDefault();
            var password = HttpContext.Current.Request.Form.GetValues("password").FirstOrDefault();
            var u = new UserRepository();
            var user = u.GetByName(username);
            if (user == null)
                return Request.CreateResponse(HttpStatusCode.Forbidden, "");
            if (new PasswordHasher().VerifyHashedPassword(user.PasswordHash, password)>0)
                return Request.CreateResponse(HttpStatusCode.OK, "fzfjt9gxt3");
            else
                return Request.CreateResponse(HttpStatusCode.Forbidden, "");
        }
    }
}
