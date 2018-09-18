using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreRadOO;

namespace TreRadTest
{
    [TestClass]
    public class BoardModelTest
    {
        [TestMethod]
        public void TestSetChar()
        {
            var bm = new BoardModel();

            bm.SetCross("a1");
            bm.SetCircle("b1");

            Assert.AreEqual('x', bm.Cells[0].GetSymbol());
            Assert.AreEqual('o', bm.Cells[1].GetSymbol());

        }

        [TestMethod]
        public void TestSetCharFail()
        {
            var bm = new BoardModel();

            bm.SetCross("a1");

            Assert.IsFalse(bm.SetCross("a1"));

            Assert.IsFalse(bm.SetCross("a4"));

        }

        [TestMethod]
        public void TestRandomCircle()
        {
            var bm = new BoardModel();

            bm.SetRandomCircle();

            var hasCircle = bm.Cells.Any(c => c.GetSymbol() == 'o');

            Assert.IsTrue(hasCircle);
        }
    }
}
