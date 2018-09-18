using System;
using System.Collections.Generic;

namespace InputOutput
{
    public class WordProcessing
    {
        private static readonly Random Rnd = new Random();

        public static bool FindWord(string[] ordListe, string[] fullOrdListe)
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

        public static string[] CheckLength(string[] fullOrdListe)
        {
            var ordListe = new List<string>();
            foreach (var word in fullOrdListe)
            {
                if (word.Length >= 7 && word.Length <= 10)
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
    }
}