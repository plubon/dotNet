using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Enitites;
using Repository;

namespace WebApp.Controllers
{
    public class TeamsController : Controller
    {
        InMemoryCache cache = new InMemoryCache();
        TeamRepository teamRepo = new TeamRepository();
        UserRepository userRepository = new UserRepository();
        // GET: Teams
        public ActionResult Index()
        {
            ViewData["teams"] = cache.GetOrSet("teams.allTeams",()=>teamRepo.GetAll());
            return View();
        }
        
        public ActionResult Team(int id)
        {
            if (System.Web.HttpContext.Current.User != null &&
                System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                User user = userRepository.GetByName(System.Web.HttpContext.Current.User.Identity.Name);
                ViewData["uid"] = user.Id;
                ViewData["followed"] = false;
                foreach (Team team in user.FollowedTeams)
                {
                    if (team.Id == id)
                    {
                        ViewData["followed"] = true;
                        break;
                    }
                }
            }
            ViewData["team"] = cache.GetOrSet("teams.team"+id,()=>teamRepo.GetById(id));
            return View();
        }
    }
}






