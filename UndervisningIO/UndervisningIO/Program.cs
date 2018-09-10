using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningIO
{
    class Program
    {
        /*
         * Input og Output skjerm/tastatur
         * Input og Output fil
         *
         * Encoding
         * using - for å dispose fil-resurser
         * List<string> - ToArray()
         * string.contains
         * string.Length
         * string.Substring
         *
         * Random
         */

        static void Main(string[] args)
        {
            //var path = @"C:\Users\Alex\source\repos\GetIT\UndervisningIO\UndervisningIO\data.txt";
            //var myList = ListFromFile(path);
            //ShowLines(myList);


            Console.Write("Hei, hva heter du? ");
            var name = Console.ReadLine();

            if (string.IsNullOrEmpty(name)) return;
            Console.WriteLine("Hei, "
                              + name.Substring(0, 1).ToUpper()
                              + name.Substring(1).ToLower());


            EncodingTest();

            //Console.WriteLine($"Hei, navnet ditt er {name?.Length} langt!");

            //if (name.ToLower().Contains("er"))
            //{
            //    Console.WriteLine($"Navnet ditt inneholder \"er\".");
            //}
        }

        private static void EncodingTest()
        {
            var path = @"C:\Users\Alex\source\repos\GetIT\UndervisningIO\UndervisningIO\data.txt";
            File.ReadAllText(path, Encoding.UTF8);
        }

        private static void ShowLines(string[] myList)
        {
            for (var index = 0; index < myList.Length; index++)
            {
                var line = myList[index];
                Console.WriteLine($"{index}: {line}");
            }
        }

        private static string[] ListFromFile(string path)
        {
            var myList = new List<string>();

            using (var streamReader = File.OpenText(path))
            {
                string line;
                var lineNo = 1;
                do
                {
                    line = streamReader.ReadLine();
                    if (line == null) continue;
                    myList.Add(line);
                    lineNo++;
                } while (line != null);
            }

            return myList.ToArray();
        }
    }
}
