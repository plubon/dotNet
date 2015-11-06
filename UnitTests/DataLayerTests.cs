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
            var a = new Discipline();
            a.Name = "test";
            a.Description = "test";
            d.SaveOrUpdate(a);
            LeagueRepository l = new LeagueRepository();
            var x = new League();
            x.Name = "test league";
            x.Description = "test";
            x.Discipline = a;
            l.SaveOrUpdate(x);
            d.Delete(a);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestDbAccess()
        {

            DisciplineRepository d = new DisciplineRepository();
            var a = new Discipline();
            a.Name = "test";
            a.Description = "test";
            d.SaveOrUpdate(a);
            using (var session = HibernateConfiguration.GetSession())
            {
                var result = session.QueryOver<Discipline>().List();
                Assert.IsTrue(result.Count > 0);
            }
        }

        [TestMethod]
        public void TestAbstractRepo()
        {
            var repo = new DisciplineRepository();
            var d=repo.GetById(1);
            Assert.IsNotNull(d);
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
