using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Good_Night.Repository;
using Good_Night.Model;

namespace TestGood_Night
{
    [TestClass]
    public class SleepRepositoryTests
    {
        private static SleepEventRepository repo;

        [ClassInitialize]
        public static void Setup(TestContext _context)
        {
            repo = new SleepEventRepository();
            repo.Clear();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            repo.Clear();
            repo.Dispose();
        }

        [TestMethod]
        public void DatabaseAddItem()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new SleepEvent(7, 30, "2/15/2015", 7, 8));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void DatabaseGetCount()
        {
            repo.Clear();
            repo.Add(new SleepEvent(12, 15, "2/14/2015", 5, 9));
            repo.Add(new SleepEvent(6, 25, "2/15/2015", 7, 5));
            Assert.AreEqual(2, repo.GetCount());
        }

        [TestMethod]
        public void DatabaseClearAll()
        {
            repo.Add(new SleepEvent(12, 15, "2/14/2015", 5, 9));
            repo.Add(new SleepEvent(6, 25, "2/15/2015", 7, 5));
            repo.Clear();
            Assert.AreEqual(0, repo.GetCount());
        }

        [TestMethod]
        public void DatabaseDeleteItem()
        {
            repo.Clear();
            Assert.AreEqual(0, repo.GetCount());
            SleepEvent longsleep = new SleepEvent(10, 30, "2/16/2015", 6, 8);
            repo.Add(longsleep);
            Assert.AreEqual(1, repo.GetCount());
            repo.Delete(longsleep);
            Assert.AreEqual(0, repo.GetCount());
        }

        [TestMethod]
        public void TestSumHours()
        {
            SleepEvent sleep1 = new SleepEvent(10, 30, "2/15/2015", 7, 8);
            SleepEvent sleep2 = new SleepEvent(8, 20, "2/16/2015", 6, 7);
            SleepEvent sleep3 = new SleepEvent(7, 10, "2/17/2015", 5, 6);
            SleepEvent sleep4 = new SleepEvent(5, 40, "2/18/2015", 4, 5);
            repo.Add(sleep1);
            repo.Add(sleep2);
            repo.Add(sleep3);
            repo.Add(sleep4);
            Assert.AreEqual(30, repo.SumHours());
        }
    }
}
