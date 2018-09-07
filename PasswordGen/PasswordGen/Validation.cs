using System;
using System.Linq;

namespace PasswordGen
{
    class Validation
    {
        public static bool IsValid(string[] args)
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
    }
}