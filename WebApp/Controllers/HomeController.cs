using Model.Enitites;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        InMemoryCache cache = new InMemoryCache();
        public ActionResult Index()
        {
            MatchRepository _repository = new MatchRepository();
            UserRepository userRepository = new UserRepository();
            if(System.Web.HttpContext.Current.User != null && System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                IEnumerable<Match> tempFollowed =  _repository.GetMatchesOfFollowedTeams(userRepository.GetByName(System.Web.HttpContext.Current.User.Identity.Name).Id);
                ViewData["followedMatches"] = tempFollowed.OrderBy(o => o.Date).Reverse().ToList();
            }
            IEnumerable<Match> tempAll = cache.GetOrSet("home.allMatches", ()=>_repository.GetAll());
            ViewData["allMatches"] = tempAll.OrderBy(o => o.Date).Reverse().ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}