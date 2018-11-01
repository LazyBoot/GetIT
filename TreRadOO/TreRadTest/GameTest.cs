using NUnit.Framework;
using System.Collections.Generic;
using TreRadOO;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

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

	public class GameTestData
	{
		public static IEnumerable<TestCaseData> TestWinnerData
		{
			get
			{
				yield return new TestCaseData(0,1,2);
				yield return new TestCaseData(3,4,5);
				yield return new TestCaseData(6,7,8);
				yield return new TestCaseData(0,3,6);
				yield return new TestCaseData(1,4,7);
				yield return new TestCaseData(2,5,8);
				yield return new TestCaseData(0,4,8);
				yield return new TestCaseData(2,4,6);
			}
		}
	}
}
