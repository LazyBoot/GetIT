﻿using System.Collections;
using System.Collections.Generic;
using TreRadOO;

namespace TreRadTestXUnit.TestData
{
	class GameTestData : IEnumerable<object[]>
	{
		private readonly List<object[]> _data = new List<object[]>
		{
			new object[] {0, 1, 2, CellOwner.Player1},
			new object[] {3, 4, 5, CellOwner.Player1},
			new object[] {6, 7, 8, CellOwner.Player1},
			new object[] {0, 3, 6, CellOwner.Player1},
			new object[] {1, 4, 7, CellOwner.Player1},
			new object[] {2, 5, 8, CellOwner.Player1},
			new object[] {0, 4, 8, CellOwner.Player1},
			new object[] {2, 4, 6, CellOwner.Player1},

			new object[] {0, 1, 2, CellOwner.Player2},
			new object[] {3, 4, 5, CellOwner.Player2},
			new object[] {6, 7, 8, CellOwner.Player2},
			new object[] {0, 3, 6, CellOwner.Player2},
			new object[] {1, 4, 7, CellOwner.Player2},
			new object[] {2, 5, 8, CellOwner.Player2},
			new object[] {0, 4, 8, CellOwner.Player2},
			new object[] {2, 4, 6, CellOwner.Player2},

			new object[] {0, 1, 2, CellOwner.None},
			new object[] {3, 4, 5, CellOwner.None},
			new object[] {6, 7, 8, CellOwner.None},
			new object[] {0, 3, 6, CellOwner.None},
			new object[] {1, 4, 7, CellOwner.None},
			new object[] {2, 5, 8, CellOwner.None},
			new object[] {0, 4, 8, CellOwner.None},
			new object[] {2, 4, 6, CellOwner.None},

		};

		public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}
