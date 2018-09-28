using System;

namespace FlaskeOppgaver
{
    class Operations
    {
        public static void TryWithGivenNumberOfOperations(int numberOfOperations, Bottle bottle1, Bottle bottle2, int wantedVolume)
        {
            Console.WriteLine("Prøver med " + numberOfOperations + " operasjon(er).");
            var operations = new int[numberOfOperations];

            while (true)
            {
                DoOperations(operations, bottle1, bottle2);
                CheckIfSolvedAndExit(bottle1, bottle2, wantedVolume, operations);
                var success = UpdateOperations(operations);
                if (!success) break;
            }
        }

        private static void CheckIfSolvedAndExit(Bottle bottle1, Bottle bottle2, int wantedVolume, int[] operations)
        {
            if (bottle1.Content != wantedVolume && bottle2.Content != wantedVolume && bottle1.Content + bottle2.Content != wantedVolume) return;
            Console.WriteLine();
            Console.WriteLine($"Fant riktig volum ({wantedVolume}) med {operations.Length} operasjoner:");
            ShowOperations(operations);
            Environment.Exit(0);
        }

        private static void ShowOperations(int[] operations)
        {
            var texts = new[]
            {
                "Fylle flaske 1 fra springen",
                "Fylle flaske 2 fra springen",
                "Tømme flaske 1 i flaske 2",
                "Tømme flaske 2 i flaske 1",
                "Fylle opp flaske 2 med flaske 1",
                "Fylle opp flaske 1 med flaske 2",
                "Tømme flaske 1 (kaste vannet)",
                "Tømme flaske 2 (kaste vannet)",
            };
            foreach (var operation in operations)
            {
                Console.WriteLine(" " + texts[operation]);
            }
        }

        private static bool UpdateOperations(int[] operations)
        {
            int i;
            for (i = operations.Length - 1; i >= 0; i--)
            {
                if (operations[i] < 8)
                {
                    operations[i]++;
                    break;
                }
                operations[i] = 0;
            }
            return i != -1;
        }

        private static void DoOperations(int[] operations, Bottle bottle1, Bottle bottle2)
        {
            bottle1.Empty();
            bottle2.Empty();

            foreach (var operation in operations)
            {
                if (operation == 0) bottle1.FillFromTap(); // Fylle flaske 1 fra springen
                else if (operation == 1) bottle2.FillFromTap(); // Fylle flaske 2 fra springen
                else if (operation == 2) bottle2.Fill(bottle1.Empty()); // Tømme flaske 1 i flaske 2 - 
                                                                        // Tanken er at Empty() returnerer hvor mye det var i flasken før den ble tømt
                else if (operation == 3) bottle1.Fill(bottle2.Empty()); // Tømme flaske 2 i flaske 1
                else if (operation == 4) bottle2.FillToTop(bottle1); // Fylle opp flaske 2 med flaske 1
                                                                     // Tanken er at FillToTop tar en annen Bottle som parameter. Hvis det er nok, fyller den 
                                                                     // bottle2 og reduserer bottle1 tilsvarende. Hvis ikke gjør den ingenting.
                else if (operation == 5) bottle1.FillToTop(bottle2); // Fylle opp flaske 1 med flaske 2
                else if (operation == 6) bottle1.Empty(); // Tømme flaske 1 (kaste vannet)
                else if (operation == 7) bottle2.Empty(); // Tømme flaske 2 (kaste vannet)
            }
        }
    }
}