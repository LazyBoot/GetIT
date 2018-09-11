using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace InputOutput
{
    class Program
    {
        private static readonly Random Rnd = new Random();

        static void Main(string[] args)
        {
            var file = args.Length != 0 ? args[0] : "fullform_bm.txt";

            var fullOrdListe = ReadWords(file);

            var ordListe = CheckLength(fullOrdListe);

            //for (int i = 0; i < 200; i++)
            //{
            //    FindWord(ordListe, fullOrdListe);
            //}

            var funnetOrd = 0;
            while (funnetOrd < 200)
            {
                if (FindWord(ordListe, fullOrdListe))
                    funnetOrd++;
            }
        }

        private static bool FindWord(string[] ordListe, string[] fullOrdListe)
        {
            var randomWord = ordListe[Rnd.Next(0, ordListe.Length)];

            var lastPart = randomWord.Substring(randomWord.Length - 3);
            var foundWord = CheckRandom(ordListe, lastPart);
            if (string.IsNullOrEmpty(foundWord))
            {
                lastPart = randomWord.Substring(randomWord.Length - 4);
                foundWord = CheckRandom(ordListe, lastPart);
            }

            if (string.IsNullOrEmpty(foundWord))
            {
                lastPart = randomWord.Substring(randomWord.Length - 5);
                foundWord = CheckRandom(ordListe, lastPart);
            }

            if (!string.IsNullOrEmpty(foundWord) && Array.IndexOf(fullOrdListe, lastPart) != -1)
            {
                Console.WriteLine($"Fant {randomWord} og {foundWord} - match: {lastPart}");
                return true;
            }

            return false;
        }

        private static string[] CheckLength(string[] fullOrdListe)
        {
            var ordListe = new List<string>();
            foreach (var word in fullOrdListe)
            {
                if (word.Length >= 7 && word.Length <= 10 && !word.Contains('-'))
                    ordListe.Add(word);
            }

            return ordListe.ToArray();
        }

        private static string CheckRandom(string[] ordListe, string lastPart)
        {
            var foundWord = string.Empty;
            foreach (var word in ordListe)
            {
                if (word.Substring(0, lastPart.Length) == lastPart)
                {
                    foundWord = word;
                    break;
                }
            }

            return foundWord;
        }

        private static string[] ReadWords(string file)
        {
            //var lastWord = string.Empty;
            var ordListe = new List<string>();
            var ordListeFil = File.ReadAllLines(file, Encoding.UTF8);
            for (var index = 30; index < ordListeFil.Length; index++)
            {
                var word = ordListeFil[index].Split('\t')[1];

                //if (word == lastWord)
                //    continue;
                //lastWord = word;


                ordListe.Add(word.ToLower());
            }

            return ordListe.Distinct().ToArray();
        }
    }
}
