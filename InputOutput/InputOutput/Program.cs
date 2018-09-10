using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullOrdListe = ReadWords();

            var ordListe = CheckLength(fullOrdListe);

            for (int i = 0; i < 200; i++)
            {
                FindWord(ordListe, fullOrdListe);
                Thread.Sleep(10);
            }

        }

        private static void FindWord(string[] ordListe, string[] fullOrdListe)
        {
            Random rnd = new Random();

            var randomWord = ordListe[rnd.Next(0, ordListe.Length)];

            var lastPart = randomWord.Substring(randomWord.Length - 3);
            var foundWord = CheckRandom(randomWord, ordListe, lastPart);
            if (string.IsNullOrEmpty(foundWord))
            {
                lastPart = randomWord.Substring(randomWord.Length - 4);
                foundWord = CheckRandom(randomWord, ordListe, lastPart);
            }

            if (string.IsNullOrEmpty(foundWord))
            {
                lastPart = randomWord.Substring(randomWord.Length - 5);
                foundWord = CheckRandom(randomWord, ordListe, lastPart);
            }

            if (!string.IsNullOrEmpty(foundWord) && Array.IndexOf(fullOrdListe, lastPart) != -1)
            {
                Console.WriteLine($"Fant {randomWord} og {foundWord} - match: {lastPart}");
            }
        }

        private static string[] CheckLength(string[] fullOrdListe)
        {
            var ordListe = new List<string>();
            foreach (var word in fullOrdListe)
            {
                if ((word.Length == 7 || word.Length == 8 || word.Length == 9 || word.Length == 10) && !word.Contains('-'))
                    ordListe.Add(word);
            }

            return ordListe.ToArray();
        }

        private static string CheckRandom(string randomWord, string[] ordListe, string lastPart)
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

        private static string[] ReadWords()
        {
            var lastWord = string.Empty;
            var ordListe = new List<string>();
            var ordListeFil = File.ReadAllLines("fullform_bm.txt", Encoding.UTF8);
            for (var index = 30; index < ordListeFil.Length; index++)
            {
                var word = ordListeFil[index].Split('\t')[1];

                if (word == lastWord)
                    continue;
                lastWord = word;


                ordListe.Add(word);
            }

            return ordListe.ToArray();
        }
    }
}
