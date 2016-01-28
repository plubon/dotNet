using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Enitites;
using Repository;

namespace WebApp.Controllers
{
    public class MatchesController : Controller
    {
        InMemoryCache cache = new InMemoryCache();
        LeagueRepository leagueRepository = new LeagueRepository();
        MatchRepository matchRepository = new MatchRepository();
        BetRepository betRepository = new BetRepository();
        UserRepository userRepository = new UserRepository();
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

        public ActionResult Upcoming()
        {
            IEnumerable<Match> allMatches = cache.GetOrSet("home.allMatches",()=>matchRepository.GetAll());
            if (System.Web.HttpContext.Current.User != null &&
                System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                User user = userRepository.GetByName(System.Web.HttpContext.Current.User.Identity.Name);

                IEnumerable<Bet> bets = user.Bets;
                ViewData["bets"] = bets;
            }
            List<Match> upcomingMatches = new List<Match>();

            foreach (Match match in allMatches)
            {
                if (match.AwayTeamScore == null)
                {
                    upcomingMatches.Add(match);
                }
            }
            ViewData["matches"] = upcomingMatches.OrderBy(o=> o.Date);
            return View();
        }
    }
}