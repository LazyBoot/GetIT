using System;
using System.Linq;

namespace PurePuzzles
{
    internal class WordStats
    {
        public static void ShowWordStats()
        {
            Console.Write("Enter a sentence, without punctuation: ");
            var words = (Console.ReadLine() ?? string.Empty).Split(' ');

            if (words.Length == 0) words = "This is a test sentence".Split(' ');

            var sortedWords = words.OrderByDescending(w => w.Length).ToArray();

            // ReSharper disable once StringLiteralTypo
            const string vowels = "AEIOUYW";

            var vowelCounts = new int[sortedWords.Length];
            for (var i = 0; i < sortedWords.Length; i++)
            {
                foreach (var letter in sortedWords[i])
                {
                    if (vowels.Contains(letter.ToString().ToUpper())) vowelCounts[i]++;
                }
            }

            var mostVowels = 0;
            for (var i = 0; i < vowelCounts.Length; i++)
            {
                if (i == 0) continue;

                if (vowelCounts[i] > vowelCounts[mostVowels])
                {
                    mostVowels = i;
                }
            }

            Console.WriteLine($"Number of words: {sortedWords.Length}");
            Console.WriteLine($"Longest Word: {sortedWords[0]} ({sortedWords[0].Length})");
            Console.WriteLine($"Most vowels: {sortedWords[mostVowels]} ({vowelCounts[mostVowels]})");
        }
    }
}