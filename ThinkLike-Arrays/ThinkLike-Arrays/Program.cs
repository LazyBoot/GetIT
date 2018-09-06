using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkLike_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var intArray = new int[6];
            var sorted = false;
            while (!sorted)
            {

                for (var i = 0; i < intArray.Length; i++)
                {
                    intArray[i] = rnd.Next(1, 100);
                }

                foreach (var i in intArray)
                {
                    Console.Write($"{i} ");
                }
                Console.Write(Environment.NewLine);

                sorted = IsArraySorted(intArray);
                Console.WriteLine(sorted);
                Console.Write(Environment.NewLine);
            }
        }

        private static bool IsArraySorted(int[] intArray)
        {
            var intArrayLength = intArray.Length;
            for (var i = 1; i < intArrayLength; i++)
            {
                if (intArray[i - 1] > intArray[i])
                    return false;
            }

            return true;
        }
    }
}
