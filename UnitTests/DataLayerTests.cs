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
        public void TestDbAccess()
        {
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
    }
}
