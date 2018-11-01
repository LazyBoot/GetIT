using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TreRadTestXUnit
{
	class GameTestData : IEnumerable<object[]>
	{
		private readonly List<object[]> _data = new List<object[]>
		{
			new object[] {0, 1, 2},
			new object[] {3, 4, 5},
			new object[] {6, 7, 8},
			new object[] {0, 3, 6},
			new object[] {1, 4, 7},
			new object[] {2, 5, 8},
			new object[] {0, 4, 8},
			new object[] {2, 4, 6},
		};

		public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}
