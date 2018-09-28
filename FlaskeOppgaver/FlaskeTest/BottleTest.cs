using FlaskeOppgaver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlaskeTest
{
    [TestClass]
    public class BottleTest
    {
        [TestMethod]
        public void TestNewBottle()
        {
            var bottle = new Bottle(10);
            Assert.AreEqual(10, bottle.Capacity);
        }

        [TestMethod]
        public void TestBottleFillTap()
        {
            var bottle = new Bottle(10);
            bottle.FillFromTap();

            Assert.AreEqual(10, bottle.Content);
        }

        [TestMethod]
        public void TestBottleEmpty()
        {
            var bottle = new Bottle(10);
            bottle.FillFromTap();

            Assert.AreEqual(10, bottle.Content);

            var oldContent = bottle.Empty();

            Assert.AreEqual(10, oldContent);
            Assert.AreEqual(0, bottle.Content);
        }

        [TestMethod]
        public void TestBottleFillOther()
        {
            var bottle = new Bottle(10);
            var bottle2 = new Bottle(5);

            bottle2.FillFromTap();
            bottle.Fill(bottle2.Empty());

            Assert.AreEqual(5, bottle.Content);
            Assert.AreEqual(0, bottle2.Content);
        }

        [TestMethod]
        public void TestBottleFillToTop()
        {
            var bottle = new Bottle(10);
            var bottle2 = new Bottle(5);

            bottle2.FillFromTap();
            bottle.FillToTop(bottle2);

            Assert.AreEqual(0, bottle2.Content);
            Assert.AreEqual(5, bottle.Content);
        }
    }
}
