using TreRadOO;
using Xunit;

namespace TreRadTestXUnit
{
	public class GameTest
	{

		[Theory]
		[ClassData(typeof(GameTestData))]
		public void TestWinner(int cell0, int cell1, int cell2, CellOwner winner)
		{
			string winText = null;
			if (winner == CellOwner.Player1)
			{
				winText = "Du";
			}
			else if (winner == CellOwner.Player2)
			{
				winText = "Datamaskinen";
			}
			var bm = GetTestBoard(cell0, cell1, cell2, winner);
			if (!string.IsNullOrEmpty(winText))
			{
				Assert.True(Game.CheckWin(bm));
			}
			else
			{
				Assert.False(Game.CheckWin(bm));
			}

			Assert.Equal(winText, Game.Winner);
		}

		[Fact]
		public void TestNoWinner()
		{
			var bm = new BoardModel();
			Assert.False(Game.CheckWin(bm));
			Assert.Null(Game.Winner);
		}

		private static BoardModel GetTestBoard(int cell1, int cell2, int cell3, CellOwner winner)
		{
			var bm = new BoardModel();
			bm.Cells[cell1].SetSymbol(winner);
			bm.Cells[cell2].SetSymbol(winner);
			bm.Cells[cell3].SetSymbol(winner);
			return bm;
		}
	}
}
