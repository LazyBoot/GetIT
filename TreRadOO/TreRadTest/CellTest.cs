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
            cell.SetSymbol('x');
            Assert.AreEqual('x', cell.GetSymbol());

            cell.SetSymbol('o');
            Assert.AreNotEqual('o', cell.GetSymbol());
        }
    }
}
