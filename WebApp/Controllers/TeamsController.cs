using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository;

namespace WebApp.Controllers
{
    public class TeamsController : Controller
    {
        InMemoryCache cache = new InMemoryCache();
        TeamRepository teamRepo = new TeamRepository();
        // GET: Teams
        public ActionResult Index()
        {
            ViewData["teams"] = cache.GetOrSet("teams.allTeams",()=>teamRepo.GetAll());
            return View();
        }
        
        public ActionResult Team(int id)
        {
            ViewData["team"] = cache.GetOrSet("teams.team"+id,()=>teamRepo.GetById(id));
            return View();
        }
    }
}






