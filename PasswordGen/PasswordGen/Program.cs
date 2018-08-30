using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGen
{
    class Program
    {
        static  readonly Random Random = new Random();
        static void Main(string[] args)
        {
            if (!IsValid(args))
            {
                ShowOptions();
                return;
            }

            GeneratePasswordFromPattern(args);
        }

        private static void GeneratePasswordFromPattern(string[] args)
        {
            string pattern = args[1].PadRight(Convert.ToInt16(args[0]), 'l');

            while (pattern.Length > 0)
            {
                var patternPos = Random.Next(0, pattern.Length - 1);
                switch (pattern[patternPos])
                {
                    case 'l':
                        WriteRandomLowerCaseLetter();
                        break;
                    case 'L':
                        WriteRandomUpperCaseLetter();
                        break;
                    case 'd':
                        WriteRandomDigit();
                        break;
                    case 's':
                        WriteRandomSpecialCharacter();
                        break;
                }

                pattern = pattern.Remove(patternPos, 1);
            }
            Console.Write("\n");
        }

        private static void WriteRandomLowerCaseLetter()
        {
            Console.Write(GetRandomLetter('a','z'));
        }

        private static void WriteRandomUpperCaseLetter()
        {
            Console.Write(GetRandomLetter('A','Z'));
        }

        private static void WriteRandomDigit()
        {
            Console.Write(Random.Next(0, 9));
        }

        private static void WriteRandomSpecialCharacter()
        {
            var specialCharacters = @"!""#¤%&/(){}[]";
            Console.Write(specialCharacters[Random.Next(0,specialCharacters.Length-1)]);
        }

        private static char GetRandomLetter(char min, char max)
        {
            return (char) Random.Next(min, max);
        }

        private static bool IsValid(string[] args)
        {
            return args.Length == 2 && CheckNumber(args[0]) && CheckOptions(args[1]);
        }

        private static bool CheckOptions(string s)
        {
            foreach (var c in s)
            {
                switch (c)
                {
                    case 'l': break;
                    case 'L': break;
                    case 'd': break;
                    case 's': break;
                    default: return false;
                }
            }

            return true;
        }

        private static bool CheckNumber(string s)
        {
            foreach (var c in s)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private static void GenPassword()
        {
            throw new NotImplementedException();
        }

        private static void ShowOptions()
        {
            Console.WriteLine(@"PasswordGenerator  
                Options:
                 - l = lower case letter
                 - L = upper case letter
                 - d = digit
                 - s = special character !""#¤%&/(){}[]
                Example: PasswordGenerator 14 lLssdd
                 Min. 1 lower case
                 Min. 1 upper case
                 Min. 2 special characters
                 Min. 2 digits");
        }
    }
}
