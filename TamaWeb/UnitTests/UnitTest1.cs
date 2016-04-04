using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TamaWeb.Models;
using TamaWeb.Spelregels;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        Tamagotchi tamagotchi;

        [TestInitialize]
        public void TestInitialize()
        {
            tamagotchi = new Tamagotchi("flip");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        [TestCategory("Spelregel")]
        public void Honger()
        {
            var honger = new Honger();
            honger.ExecuteSpelregel(tamagotchi, 0);
        }
    }
}
