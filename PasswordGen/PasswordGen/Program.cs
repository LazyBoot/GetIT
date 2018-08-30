using System;
using System.IO;
using System.Reflection;

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

            var password = GeneratePasswordFromPattern(args);
            Console.WriteLine(password);
            System.IO.File.AppendAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\password.txt", password + "\n");
        }

        private static string GeneratePasswordFromPattern(string[] args)
        {
            string pattern = args[1].PadRight(Convert.ToInt16(args[0]), 'l');
            string password = string.Empty;
            while (pattern.Length > 0)
            {
                var patternPos = Random.Next(0, pattern.Length - 1);
                switch (pattern[patternPos])
                {
                    case 'l':
                        password += WriteRandomLowerCaseLetter();
                        break;
                    case 'L':
                        password += WriteRandomUpperCaseLetter();
                        break;
                    case 'd':
                        password += WriteRandomDigit();
                        break;
                    case 's':
                        password += WriteRandomSpecialCharacter();
                        break;
                }

                pattern = pattern.Remove(patternPos, 1);
            }

            return password;
        }

        private static char WriteRandomLowerCaseLetter()
        {
            return GetRandomLetter('a','z');
        }

        private static char WriteRandomUpperCaseLetter()
        {
            return GetRandomLetter('A','Z');
        }

        private static int WriteRandomDigit()
        {
            return Random.Next(0, 9);
        }

        private static char WriteRandomSpecialCharacter()
        {
            var specialCharacters = @"!""#¤%&/(){}[]";
            return specialCharacters[Random.Next(0,specialCharacters.Length-1)];
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

            if (Convert.ToInt64(s) > short.MaxValue)
            {
                Console.WriteLine("Max allowed length is " + short.MaxValue);
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
