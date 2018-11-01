using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TreRadOO;

namespace TreRadTestXUnit.TestData
{
	public class BoardViewTestData
	{
		public static IEnumerable<object[]> GetSymbolTestData() =>
			new List<object[]>
			{
				new object[] {0, CellOwner.None},
				new object[] {1, CellOwner.None},
				new object[] {2, CellOwner.None},
				new object[] {3, CellOwner.None},
				new object[] {4, CellOwner.None},
				new object[] {5, CellOwner.None},
				new object[] {6, CellOwner.None},
				new object[] {7, CellOwner.None},
				new object[] {8, CellOwner.None},

				new object[] {0, CellOwner.Player1},
				new object[] {1, CellOwner.Player1},
				new object[] {2, CellOwner.Player1},
				new object[] {3, CellOwner.Player1},
				new object[] {4, CellOwner.Player1},
				new object[] {5, CellOwner.Player1},
				new object[] {6, CellOwner.Player1},
				new object[] {7, CellOwner.Player1},
				new object[] {8, CellOwner.Player1},

				new object[] {0, CellOwner.Player2},
				new object[] {1, CellOwner.Player2},
				new object[] {2, CellOwner.Player2},
				new object[] {3, CellOwner.Player2},
				new object[] {4, CellOwner.Player2},
				new object[] {5, CellOwner.Player2},
				new object[] {6, CellOwner.Player2},
				new object[] {7, CellOwner.Player2},
				new object[] {8, CellOwner.Player2},
			};

		public static IEnumerable<object[]> ShowTestData =>
			new List<object[]>
			{
				new object[] {0, 1, 2},
				new object[] {0, 6, 8},
				new object[] {3, 1, 5},
			};
	}
}
