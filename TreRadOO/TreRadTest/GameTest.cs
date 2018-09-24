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
            var bm = new BoardModel();

            TestCells(bm, 0, 1, 2);
            TestCells(bm, 3, 4, 5);
            TestCells(bm, 6, 7, 8);
            TestCells(bm, 0, 3, 6);
            TestCells(bm, 1, 4, 7);
            TestCells(bm, 2, 5, 8);
            TestCells(bm, 0, 4, 8);
            TestCells(bm, 2, 4, 6);

            
        }

        private void TestCells(BoardModel bm, int cell1, int cell2, int cell3)
        {
            bm.Cells[cell1].SetSymbol(CellOwner.Cross);
            bm.Cells[cell2].SetSymbol(CellOwner.Cross);
            bm.Cells[cell3].SetSymbol(CellOwner.Cross);

            Game.CheckWin(bm);
            Assert.AreEqual("Du", Game.Winner);

            bm.Cells[cell1].SetSymbol(CellOwner.None);
            bm.Cells[cell2].SetSymbol(CellOwner.None);
            bm.Cells[cell3].SetSymbol(CellOwner.None);
        }

    }
}
