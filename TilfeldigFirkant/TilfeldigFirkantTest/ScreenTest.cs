using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TilfeldigFirkant;

namespace TilfeldigFirkantTest
{
    [TestClass]
    public class ScreenTest
    {
        [TestMethod]
        public void TestShow()
        {
            var box = new Box(2, 3, 4, 5);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                var screen = new Screen(10, 10);
                screen.Add(box);
                screen.Show();

                var expected = string.Format("          {0}          {0}          {0}  ┌───┐   {0}  │   │   {0}  │   │   {0}  │   │   {0}  │   │   {0}  └───┘   {0}          {0}", Environment.NewLine);

                Assert.AreEqual(expected, sw.ToString());
            }

            StreamWriter standardOut = new StreamWriter(Console.OpenStandardOutput());
            standardOut.AutoFlush = true;
            Console.SetOut(standardOut);
        }
    }
}
