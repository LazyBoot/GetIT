using System;
using System.Linq;
using TreRadOO;
using Xunit;

namespace TreRadTestXUnit
{
	public class BoardModelTest
	{
		[Fact]
		public void TestSetChar()
		{
			var bm = new BoardModel();

			bm.SetPlayer1("a1");
			bm.SetPlayer2("b1");

			Assert.Equal(CellOwner.Player1, bm.GetSymbol(0));
			Assert.Equal(CellOwner.Player2, bm.GetSymbol(1));
		}

		[Fact]
		public void TestSetCharOccupiedCell()
		{
			var bm = new BoardModel();

			bm.SetPlayer1("a1");

			Assert.False(bm.SetPlayer1("a1"));
		}

		[Fact]
		public void TestSetCharInvalidCell()
		{
			var bm = new BoardModel();

			Assert.False(bm.SetPlayer1("a4"));
		}

		[Fact]
		public void TestRandomCircle()
		{
			var bm = new BoardModel();

			bm.SetRandomPlayer2();

			var hasCircle = bm.Cells.Any(c => c.GetContent() == CellOwner.Player2);

			Assert.True(hasCircle);
		}

		[Fact]
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
			Assert.False(hasCircle);

		}
	}
}
