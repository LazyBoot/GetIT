using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreRadOO;

namespace TreRadTest
{
    [TestClass]
    public class BoardModelTest
    {
        [TestMethod]
        public void TestSetChar()
        {
            var bm = new BoardModel();

            bm.SetPlayer1("a1");
            bm.SetPlayer2("b1");

            Assert.AreEqual(CellOwner.Player1, bm.GetSymbol(0));
            Assert.AreEqual(CellOwner.Player2, bm.GetSymbol(1));
        }

        [TestMethod]
        public void TestSetCharOccupiedCell()
        {
            var bm = new BoardModel();

            bm.SetPlayer1("a1");

            Assert.IsFalse(bm.SetPlayer1("a1"));
        }

        [TestMethod]
        public void TestSetCharInvalidCell()
        {
            var bm = new BoardModel();

            Assert.IsFalse(bm.SetPlayer1("a4"));
        }

        [TestMethod]
        public void TestRandomCircle()
        {
            var bm = new BoardModel();

            bm.SetRandomPlayer2();

            var hasCircle = bm.Cells.Any(c => c.GetContent() == CellOwner.Player2);

            Assert.IsTrue(hasCircle);
        }

        [TestMethod]
        public void TestRandomFullBoard()
        {
            var bm = new BoardModel();

            bm.SetPlayer1("a1");
            bm.SetPlayer1("a2");
            bm.SetPlayer1("a3");
            bm.SetPlayer1("b1");
            bm.SetPlayer1("b2");
            bm.SetPlayer1("b3");
            bm.SetPlayer1("c1");
            bm.SetPlayer1("c2");
            bm.SetPlayer1("c3");

            bm.SetRandomPlayer2();

            var hasCircle = bm.Cells.Any(c => c.GetContent() == CellOwner.Player2);
            Assert.IsFalse(hasCircle);

        }
    }
}
