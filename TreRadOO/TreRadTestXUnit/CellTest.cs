using System;
using System.Collections.Generic;
using System.Text;
using TreRadOO;
using Xunit;

namespace TreRadTestXUnit
{
	public class CellTest
	{
		[Fact]
		public void TestSetSymbol()
		{
			var cell = new Cell();
			cell.SetSymbol(CellOwner.Player1);
			Assert.Equal(CellOwner.Player1, cell.GetContent());

			cell.SetSymbol(CellOwner.Player2);
			Assert.NotEqual(CellOwner.Player2, cell.GetContent());
		}

	}
}
