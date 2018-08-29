using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppgaveHvaGjorKoden
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadTextAndShowCharCounts(250);
        }

        private static void ReadTextAndShowCharCounts(int range)
        {
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                Array.Clear(counts, 0, counts.Length);
                text = Console.ReadLine();

                var total = CountChars(text, counts);

                ShowCounts(range, counts, total);
            }
        }

        private static void ShowCounts(int range, int[] counts, int total)
        {
            for (var i = 0; i < range; i++)
            {
                if (counts[i] <= 0) continue;
                var character = (char) i;
                var percent = (int) Math.Round((double) counts[i] / total * 100);
                Console.WriteLine(character + " - " + counts[i].ToString().PadLeft(4) + " - " +
                                  percent.ToString().PadLeft(3) + "%");
            }
        }

        private static int CountChars(string text, int[] counts)
        {
            var total = 0;
            foreach (var character in text?.ToLowerInvariant() ?? string.Empty)
            {
                counts[(int) character]++;
                total++;
            }

            return total;
        }
    }
}
