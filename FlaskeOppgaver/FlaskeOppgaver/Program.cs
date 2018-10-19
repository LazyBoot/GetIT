using System;

namespace FlaskeOppgaver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bottle1Size = 5;
            var bottle2Size = 3;
            var wantedVolume = 2;

            if (args.Length == 3)
            {
                bottle1Size = Convert.ToInt32(args[0]);
                bottle2Size = Convert.ToInt32(args[1]);
                wantedVolume = Convert.ToInt32(args[2]);
            }

            if (bottle1Size + bottle2Size < wantedVolume)
            {
                Console.WriteLine("For stort volum for flaskene!");
                return;
            }

            var bottle1 = new Bottle(bottle1Size);
            var bottle2 = new Bottle(bottle2Size);

            var numberOfOperations = 1;
            while (!Operations.TryWithGivenNumberOfOperations(numberOfOperations, bottle1, bottle2, wantedVolume))
            {
                numberOfOperations++;
            }

        }
    }
}
