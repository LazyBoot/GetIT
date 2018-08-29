using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGen
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!IsValid(args))
            {
                ShowOptions();
                return;
            }
        }

        private static bool IsValid(string[] args)
        {
            if (args.Length == 2 && CheckNumber(args[0]) && CheckOptions(args[1]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool CheckOptions(string s)
        {
            foreach (var c in s)
            {
                switch (c.ToString())
                {
                    case "l":break;
                    case "L":break;
                    case "d":break;
                    case "s":break;
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
                 - s = special character(!""#¤%&/(){}[]
                Example: PasswordGenerator 14 lLssdd
                 Min. 1 lower case
                 Min. 1 upper case
                 Min. 2 special characters
                 Min. 2 digits");
        }
    }
}
