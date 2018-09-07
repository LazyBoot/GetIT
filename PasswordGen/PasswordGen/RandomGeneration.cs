using System;
using System.Text;

namespace PasswordGen
{
    class RandomGeneration
    {
        private static readonly Random Rnd = new Random();

        public static string GeneratePasswordFromPattern(string[] args)
        {

            var password = new StringBuilder(string.Empty);
            Console.Write("Generating password...");
            using (var progress = new ProgressBar())
            {
                var length = Convert.ToInt32(args[0]);
                var pattern = new StringBuilder(args[1].PadRight(length, 'l'));
                while (pattern.Length > 0) // TODO: Multithread!
                {
                    progress.Report(1 - (double)pattern.Length / length);
                    var patternPos = Rnd.Next(0, pattern.Length - 1);
                    switch (pattern[patternPos])
                    {
                        case 'l':
                            password.Append(WriteRandomLowerCaseLetter());
                            break;
                        case 'L':
                            password.Append(WriteRandomUpperCaseLetter());
                            break;
                        case 'd':
                            password.Append(WriteRandomDigit());
                            break;
                        case 's':
                            password.Append(WriteRandomSpecialCharacter());
                            break;
                    }

                    pattern = pattern.Remove(patternPos, 1);
                }

            }
            return password.ToString();
        }

        private static char WriteRandomLowerCaseLetter()
        {
            return GetRandomLetter('a', 'z');
        }

        private static char WriteRandomUpperCaseLetter()
        {
            return GetRandomLetter('A', 'Z');
        }

        private static int WriteRandomDigit()
        {
            return Rnd.Next(0, 9);
        }

        private static char WriteRandomSpecialCharacter()
        {
            const string specialCharacters = @"!""#¤%&/(){}[]";
            return specialCharacters[Rnd.Next(0, specialCharacters.Length - 1)];
        }

        private static char GetRandomLetter(char min, char max)
        {
            return (char)Rnd.Next(min, max);
        }
    }
}