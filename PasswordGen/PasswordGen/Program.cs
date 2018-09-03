using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PasswordGen
{
    class Program
    {
        static  readonly Random Random = new Random();
        static void Main(string[] args)
        {
#if DEBUG
            var noargs = false;
            if (args.Length == 0)
            {
                Console.Write("Enter commandline arguments: ");
                args = Console.ReadLine()?.Split(' ');
                noargs = true;
            }
            File.WriteAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\password.txt", "");
            var watch = System.Diagnostics.Stopwatch.StartNew();
#endif


            if (!IsValid(args))
            {
                ShowOptions();

#if DEBUG
                watch.Stop();
                Console.WriteLine(watch.ElapsedMilliseconds);
#endif
                return;
            }

            var password = GeneratePasswordFromPattern(args);
            //Console.WriteLine(password);

            File.AppendAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\password.txt", password + Environment.NewLine);

#if DEBUG
            watch.Stop();
            Console.WriteLine("Runtime: {0} ms", watch.ElapsedMilliseconds);

            if (noargs)
            {
                Console.Write("Press any key to exit...");
                Console.ReadKey();
            }
#endif
        }

        private static string GeneratePasswordFromPattern(string[] args)
        {
            string pattern = args[1].PadRight(Convert.ToInt32(args[0]), 'l');

            char[] rndPattern = pattern.OrderBy(x => Random.Next()).ToArray();
            //var pattern = new StringBuilder(args[1].PadRight(Convert.ToInt32(args[0]), 'l'));
            var password = new StringBuilder(String.Empty);
            //while (pattern.Length > 0)
            foreach (var c in rndPattern)
            {
                //var patternPos = Random.Next(0, pattern.Length - 1);
                //switch (pattern[patternPos])
                switch (c)
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
                
                //pattern = pattern.Remove(patternPos, 1);
            }
            
            return password.ToString();
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
            const string validCharacters = "lLds";
            foreach (var c in s)
            {
                if (!validCharacters.Contains(c)) return false;
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

            if (Convert.ToInt64(s) > int.MaxValue)
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
