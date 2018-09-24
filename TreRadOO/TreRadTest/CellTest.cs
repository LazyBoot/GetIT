using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreRadOO;

namespace TreRadTest
{
    [TestClass]
    public class CellTest
    {
        [TestMethod]
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
