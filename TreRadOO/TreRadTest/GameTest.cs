using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreRadOO;

namespace TreRadTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void TestWinner()
        {
            var bm = GetTestBoard(0, 1, 2);
            Assert.IsTrue(Game.CheckWin(bm));
            Assert.AreEqual("Du", Game.Winner);
        }

        [TestMethod]
        public void TestWinner2()
        {
            var bm = GetTestBoard(3, 4, 5);
            Assert.IsTrue(Game.CheckWin(bm));
            Assert.AreEqual("Du", Game.Winner);
        }

        [TestMethod]
        public void TestWinner3()
        {
            var bm = GetTestBoard(6, 7, 8);
            Assert.IsTrue(Game.CheckWin(bm));
            Assert.AreEqual("Du", Game.Winner);
        }

        [TestMethod]
        public void TestWinner4()
        {
            var bm = GetTestBoard(0, 3, 6);
            Assert.IsTrue(Game.CheckWin(bm));
            Assert.AreEqual("Du", Game.Winner);
        }

        [TestMethod]
        public void TestWinner5()
        {
            var bm = GetTestBoard(1, 4, 7);
            Assert.IsTrue(Game.CheckWin(bm));
            Assert.AreEqual("Du", Game.Winner);
        }

        [TestMethod]
        public void TestWinner6()
        {
            var bm = GetTestBoard(2, 5, 8);
            Assert.IsTrue(Game.CheckWin(bm));
            Assert.AreEqual("Du", Game.Winner);
        }

        [TestMethod]
        public void TestWinner7()
        {
            var bm = GetTestBoard(0, 4, 8);
            Assert.IsTrue(Game.CheckWin(bm));
            Assert.AreEqual("Du", Game.Winner);
        }

        [TestMethod]
        public void TestWinner8()
        {
            var bm = GetTestBoard(2, 4, 6);
            Assert.IsTrue(Game.CheckWin(bm));
            Assert.AreEqual("Du", Game.Winner);
        }

        [TestMethod]
        public void TestNoWinner()
        {
            var bm = new BoardModel();
            Assert.IsFalse(Game.CheckWin(bm));
            Assert.AreEqual(null, Game.Winner);
        }

        private static BoardModel GetTestBoard(int cell1, int cell2, int cell3)
        {
            var bm = new BoardModel();
            bm.Cells[cell1].SetSymbol(CellOwner.Player1);
            bm.Cells[cell2].SetSymbol(CellOwner.Player1);
            bm.Cells[cell3].SetSymbol(CellOwner.Player1);
            return bm;
        }

    }
}
