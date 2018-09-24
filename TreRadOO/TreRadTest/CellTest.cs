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
            cell.SetSymbol(CellOwner.Cross);
            Assert.AreEqual(CellOwner.Cross, cell.GetContent());

            cell.SetSymbol(CellOwner.Circle);
            Assert.AreNotEqual(CellOwner.Circle, cell.GetContent());
        }
    }
}
