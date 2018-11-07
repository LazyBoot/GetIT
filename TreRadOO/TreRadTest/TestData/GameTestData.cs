using System.Collections.Generic;
using NUnit.Framework;

namespace TreRadTest
{
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