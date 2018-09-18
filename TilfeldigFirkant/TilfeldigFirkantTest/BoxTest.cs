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

        [TestMethod]
        public void TestBoxMove()
        {
            var screen = new Screen(20, 20);
            var box = new Box(2, 3, 4, 5);

            Assert.AreEqual(2, box.X);
            Assert.AreEqual(3, box.Y);

            box.Move(screen);

            Assert.AreNotEqual(2, box.X);
            Assert.AreNotEqual(3, box.Y);

        }

        [TestMethod]
        public void TestBoxMoveEdge()
        {
            var screen = new Screen(10, 10);
            var box = new Box(0, 0, 4, 4, -1, -1);
            var box2 = new Box(6, 6, 4, 4, 1, 1);

            Assert.AreEqual(0, box.X);
            Assert.AreEqual(0, box.Y);
            Assert.AreEqual(6, box2.X);
            Assert.AreEqual(6, box2.Y);

            var oldRetningX = box.RetningX;
            var oldRetningY = box.RetningY;
            var oldRetningX2 = box2.RetningX;
            var oldRetningY2 = box2.RetningY;

            box.Move(screen);
            box2.Move(screen);

            Assert.AreNotEqual(oldRetningX, box.RetningX);
            Assert.AreNotEqual(oldRetningY, box.RetningY);
            Assert.AreNotEqual(oldRetningX2, box2.RetningX);
            Assert.AreNotEqual(oldRetningY2, box2.RetningY);

        }
    }
}
