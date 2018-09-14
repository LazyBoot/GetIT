using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TilfeldigFirkant;

namespace TilfeldigFirkantTest
{
    [TestClass]
    public class ScreenCellTest
    {
        [TestMethod]
        public void TestScreenCell()
        {
            var cell = new ScreenCell();
            cell.AddLowerLeftCorner();
            cell.AddVertical();

            Assert.AreEqual('├', cell.GetCharacter());
        }
    }
}
