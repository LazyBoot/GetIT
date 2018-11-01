using System;
using System.Collections.Generic;
using System.Text;
using TreRadOO;
using Xunit;

namespace TreRadTestXUnit
{
	public class GameTest
	{
		[Theory]
		[ClassData(typeof(GameTestData))]
		public void TestWinner(int cell0, int cell1, int cell2)
		{
			var bm = GetTestBoard(cell0, cell1, cell2);
			Assert.True(Game.CheckWin(bm));
			Assert.Equal("Du", Game.Winner);
			Game.Winner = null;
		}

		[Fact]
		public void TestNoWinner()
		{
			var bm = new BoardModel();
			Assert.False(Game.CheckWin(bm));
			Assert.Null(Game.Winner);
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
