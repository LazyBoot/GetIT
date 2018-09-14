using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TilfeldigFirkant;

namespace TilfeldigFirkantTest
{
    [TestClass]
    public class BoxTest
    {
        [TestMethod]
        public void TestBox()
        {
            var box = new Box(2, 3, 4, 5);

            Assert.AreEqual(2, box.X);
            Assert.AreEqual(3, box.Y);
            Assert.AreEqual(4, box.Width);
            Assert.AreEqual(5, box.Height);
        }

        [TestMethod]
        public void TestRandomBox()
        {
            var random = new Random();
            var box = new Box(random, 9, 9);

            Assert.IsNotNull(box.X);
            Assert.IsNotNull(box.Y);
            Assert.AreNotEqual(0, box.Width);
            Assert.AreNotEqual(0, box.Height);
        }

        [TestMethod]
        public void TestBoxY()
        {
            var box = new Box(2, 3, 4, 5);

            var topY = box.GetTopRowY();
            var bottomY = box.GetBottomRowY();

            Assert.AreEqual(3, topY);
            Assert.AreEqual(8, bottomY);
        }

    }
}
