using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Model.Enitites;
using Repository;
using FootballDataAPI;
using FootballDataAPI.Responses;
using WebAPI.Controllers;

namespace UnitTests
{
    [TestClass]
    public class DataLayerTests
    {
        [TestMethod]
        public void TestDbAccess()
        {
            using (var session = HibernateConfiguration.GetSession())
            {
                var d = new Discipline();
                var repo = new DisciplineRepository();
                d.Name = "Football";
                if(!repo.ContainsName(d.Name))
                    repo.SaveOrUpdate(d);
                var result = repo.GetAll();
                Assert.IsTrue(result.Count > 0);
            }
        }


        [TestMethod]
        public void GetByDate()
        {
            var repo = new MatchRepository();
            DateTime start = new DateTime(1990,1,1);
            DateTime end = new DateTime(2020, 1, 1);

            var r = repo.GetFromTimeInterval(start,end);
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void TestGetAll()
        {
            var repo = new DisciplineRepository();

            var d = repo.GetAll();
            Assert.IsTrue(d.Count > 0);
            var x = repo.GetFromTop(1);
            Assert.IsTrue(x.Count > 0);
        }

        [TestMethod]
        public void TestRequest()
        {
            var req = new ApiRequest("http://api.football-data.org/v1/fixtures/145671");
            var res = req.GetResult<MatchResponse>();
            Assert.IsTrue(res.Fixture.AwayTeamName.Length > 0);
        }

        [TestMethod]
        public void Contains()
        {
            var repo = new DisciplineRepository();
            Assert.IsFalse(repo.ContainsName("kappa"));
        }
      

        [TestMethod]
        public void AllLeaguesFromApi()
        {
            var repo = new LeagueRepository();
            var result = repo.GetByDiscipline("Football");
            Assert.IsTrue(result.Count>0);
        }

        [TestMethod]
        public void GetLeagueById()
        {
            var repo = new LeagueRepository();
            var result = repo.GetByDiscipline("Football");
            int id = 1;
            var x = repo.GetById(1);
            Assert.IsTrue(x.Matches.Count > 0);
        }

        [TestMethod]
        public void GetTeamById()
        {
            var repo = new TeamRepository();
            var y = repo.GetById(1);
            Assert.IsTrue(y.Players.Count > 0);
        }

        [TestMethod]
        public void ContainsMatch()
        {
            var repo = new MatchRepository();
            var x = repo.GetById(1);
            Assert.IsTrue(repo.ContainsMatch(x));
        }

        [TestMethod]
        public void AllMatches()
        {
            var repo = new MatchRepository();
            var x = repo.GetAll();
            Assert.IsTrue(x.Count != 0);
        }
    }
}
