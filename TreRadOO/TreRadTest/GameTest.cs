using NUnit.Framework;
using TreRadOO;

namespace TreRadTest
{
	[TestFixture]
    public class GameTest
    {
		[TestCaseSource(typeof(GameTestData), nameof(GameTestData.TestWinnerData))]
        public void TestWinner(int cell0, int cell1, int cell2)
        {
            var bm = GetTestBoard(cell0, cell1, cell2);
            Assert.IsTrue(Game.CheckWin(bm));
            Assert.AreEqual("Du", Game.Winner);
	        Game.Winner = null;
        }

        [Test]
        public void TestNoWinner()
        {
            var bm = new BoardModel();
            Assert.IsFalse(Game.CheckWin(bm));
            Assert.AreEqual(null, Game.Winner);
	        Game.Winner = null;
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
