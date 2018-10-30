using NUnit.Framework;
using System.Linq;
using TreRadOO;

namespace TreRadTest
{
	[TestFixture]
    public class BoardModelTest
    {
        [Test]
        public void TestSetChar()
        {
            var bm = new BoardModel();

            bm.SetPlayer1("a1");
            bm.SetPlayer2("b1");

            Assert.AreEqual(CellOwner.Player1, bm.GetSymbol(0));
            Assert.AreEqual(CellOwner.Player2, bm.GetSymbol(1));
        }

        [Test]
        public void TestSetCharOccupiedCell()
        {
            var bm = new BoardModel();

            bm.SetPlayer1("a1");

            Assert.IsFalse(bm.SetPlayer1("a1"));
        }

        [Test]
        public void TestSetCharInvalidCell()
        {
            var bm = new BoardModel();

            Assert.IsFalse(bm.SetPlayer1("a4"));
        }

        [Test]
        public void TestRandomCircle()
        {
            var bm = new BoardModel();

            bm.SetRandomPlayer2();

            var hasCircle = bm.Cells.Any(c => c.GetContent() == CellOwner.Player2);

            Assert.IsTrue(hasCircle);
        }

        [Test]
        public void TestRandomFullBoard()
        {
            var bm = new BoardModel();

            bm.SetPlayer1("a1");
            bm.SetPlayer1("a2");
            bm.SetPlayer1("a3");
            bm.SetPlayer1("b1");
            bm.SetPlayer1("b2");
            bm.SetPlayer1("b3");
            bm.SetPlayer1("c1");
            bm.SetPlayer1("c2");
            bm.SetPlayer1("c3");

            bm.SetRandomPlayer2();

            var hasCircle = bm.Cells.Any(c => c.GetContent() == CellOwner.Player2);
            Assert.IsFalse(hasCircle);

        }
    }
}
