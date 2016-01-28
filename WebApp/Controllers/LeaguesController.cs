using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
  
    public class LeaguesController : Controller
    {
        readonly InMemoryCache cache = new InMemoryCache();
        readonly LeagueRepository repository = new LeagueRepository();
        // GET: Leagues
        public ActionResult Index()
        {
            ViewData["leagues"] = cache.GetOrSet("leagues.allLeagues",()=>repository.GetAll());
            return View();
        }
    }
}