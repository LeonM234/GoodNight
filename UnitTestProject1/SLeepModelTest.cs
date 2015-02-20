using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Good_Night.Model;

namespace TestGood_Night
{
    [TestClass]
    public class SleepModelTest
    {
        [TestMethod]
        public void CreatingASleepEventStoresItsProperties()
        {
            SleepEvent shortsleep = new SleepEvent(5, 20, "2/16/15", 7, 3);
            Assert.AreEqual(5, shortsleep.Hours);
            Assert.AreEqual(20, shortsleep.Minutes);
            Assert.AreEqual("2/16/15", shortsleep.Date);
            Assert.AreEqual(7, shortsleep.MorningFeels);
            Assert.AreEqual(3, shortsleep.DayFeels);
        }


    }
}
