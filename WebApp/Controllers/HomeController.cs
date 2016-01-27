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
        public ActionResult Index()
        {
            MatchRepository _repository = new MatchRepository();
            UserRepository userRepository = new UserRepository();
            if(System.Web.HttpContext.Current.User != null && System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                ViewData["followedMatches"] = _repository.GetMatchesOfFollowedTeams(userRepository.GetByName(System.Web.HttpContext.Current.User.Identity.Name).Id);
            }
            ViewData["allMatches"] = _repository.GetAll();
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