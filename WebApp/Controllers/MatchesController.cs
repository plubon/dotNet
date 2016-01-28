using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository;

namespace WebApp.Controllers
{
    public class MatchesController : Controller
    {
        InMemoryCache cache = new InMemoryCache();
        LeagueRepository leagueRepository = new LeagueRepository();
        // GET: Matches
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult League(int id)
        {
            ViewData["league"] = cache.GetOrSet("matches.league"+id,()=>leagueRepository.GetById(id));
            return View("League");
        }
    }
}