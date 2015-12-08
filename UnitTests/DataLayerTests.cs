using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Model.Enitites;
using Repository;

namespace UnitTests
{
    [TestClass]
    public class DataLayerTests
    {
        [TestMethod]
        public void TestKeys()
        {
            DisciplineRepository d = new DisciplineRepository();
            d.Delete(d.GetFromTop(1)[0]);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestDbAccess()
        {
            using (var session = HibernateConfiguration.GetSession())
            {
                var result = session.QueryOver<Discipline>().List();
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
    }
}
