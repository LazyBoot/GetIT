﻿using NUnit.Framework;
using TreRadOO;

namespace TreRadTest
{
	[TestFixture()]
    public class CellTest
    {
        [Test]
        public void TestSetSymbol()
        {
            var cell = new Cell();
            cell.SetSymbol(CellOwner.Player1);
            Assert.AreEqual(CellOwner.Player1, cell.GetContent());

            cell.SetSymbol(CellOwner.Player2);
            Assert.AreNotEqual(CellOwner.Player2, cell.GetContent());
        }
    }
}
