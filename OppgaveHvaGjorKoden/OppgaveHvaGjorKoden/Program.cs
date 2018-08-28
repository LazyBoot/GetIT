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
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                Array.Clear(counts, 0, counts.Length);
                var total = 0;
                text = Console.ReadLine();

                foreach (var character in text?.ToLowerInvariant() ?? string.Empty)
                {
                    counts[(int)character]++;
                    total++;
                }

                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        Console.WriteLine(character + " - " + counts[i].ToString().PadLeft(4) + " - " + Math.Round((float)counts[i] / total * 100).ToString().PadLeft(3) + "%");
                    }
                }

            }
        }
    }
}
