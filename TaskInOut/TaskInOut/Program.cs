using System;

namespace TaskInOut
{
    class Program
    {
        public static void Main(string[] args)
        {
            // var intArray = new int[6];
            //int[] intArray = { 1, 2, 3, 4, 5,94,1 };
            //Console.WriteLine(IsArraySorted.isArraySorted(intArray));
            string plaintext = "Ibsens Ripsbaerbusker og andre buksvekster.";
            Console.WriteLine(Ciphers.CipherArray(plaintext));
            Console.WriteLine(Ciphers.DecipherArray(Ciphers.CipherArray(plaintext)));
        }
    }

}
