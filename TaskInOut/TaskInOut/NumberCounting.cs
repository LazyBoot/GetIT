using System;

namespace TaskInOut
{
    class NumberCounting
    {
        public static int[] GenerateNumbers()
        {
            var numbers = new int[40];

            var rnd = new Random();
            for (var i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(9);
            }


            Console.WriteLine(string.Join(" ", numbers));
            return numbers;
        }

        public static void CountNumbers(int[] numbers)
        {
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