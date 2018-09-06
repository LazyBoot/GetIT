using System;
using System.Linq;

namespace TaskInOut
{
    class Program
    {
        public static void Main(string[] args)
        {
            // var intArray = new int[6];
            //int[] intArray = { 1, 2, 3, 4, 5,94,1 };
            //Console.WriteLine(IsArraySorted.isArraySorted(intArray));
            //string plaintext = "Ibsens Ripsbaerbusker og andre buksvekster.";
            //Console.WriteLine(Ciphers.CipherArray(plaintext));
            //Console.WriteLine(Ciphers.DecipherArray(Ciphers.CipherArray(plaintext)));

            var numbers = new int[40];

            var rnd = new Random();
            for (var i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(9);
            }


            Console.WriteLine(string.Join(" ", numbers));
            var numberCounts = new int[10];

            foreach (var number in numbers)
            {
                numberCounts[number]++;
            }

            var mostNumbers = 0;
            for (var i = 0; i < numberCounts.Length; i++)
            {
                if (i == 0) continue;

                if (numberCounts[i] > numberCounts[mostNumbers])
                {
                    mostNumbers = i;
                }
            }

            Console.WriteLine($"Number: {mostNumbers} - Counts: {numberCounts[mostNumbers]}");
        }
    }

}
