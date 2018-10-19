using System;
using System.IO;
using FlaskeOppgaver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlaskeTest
{
    [TestClass]
    public class OperationsTest
    {
        [TestMethod]
        public void TestTooGreatVolume()
        {
            var bottle1Size = 5;
            var bottle2Size = 3;
            var wantedVolume = 20;

            var expected = "For stort volum for flaskene!\r\n";

            DoTheTest(bottle1Size, bottle2Size, wantedVolume, expected);
        }

        [TestMethod]
        public void TestOperations1()
        {
            var bottle1Size = 5;
            var bottle2Size = 3;
            var wantedVolume = 2;

            var expected =
                "Prøver med 1 operasjon(er).\r\nPrøver med 2 operasjon(er).\r\n\r\nFant riktig volum (2) med 2 operasjoner:\r\n Fylle flaske 1 fra springen\r\n Fylle opp flaske 2 med flaske 1\r\n";

            DoTheTest(bottle1Size, bottle2Size, wantedVolume, expected);
        }

        public void DoTheTest(int bottle1Size, int bottle2Size, int wantedVolume, string expected)
        {
            var oldOut = new StreamWriter(Console.OpenStandardOutput());
            oldOut.AutoFlush = true;

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                
                Program.Main(new []{bottle1Size.ToString(), bottle2Size.ToString(), wantedVolume.ToString()});


                Assert.AreEqual(expected, sw.ToString());
            }

            Console.SetOut(oldOut);
        }
    }
}
