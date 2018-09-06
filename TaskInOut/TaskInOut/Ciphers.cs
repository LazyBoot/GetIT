using System;
using System.Linq;
using System.Security.Cryptography;

namespace TaskInOut
{
    class Ciphers
    {
        private static Random rnd = new Random();
        private static readonly char[] Alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static char[] cipherKey = ScrambleProperly();
        //private static char[] cipherKey = alpha.OrderBy(x=>scramble.Next()).ToArray();

        public static string CipherArray(string plainText)
        {
            plainText = plainText.ToUpper();
            var outputText = string.Empty;
            foreach (var character in plainText)
            {
                if (Alpha.Contains(character))
                {
                    //var index = Array.IndexOf(second, character);
                    outputText += cipherKey[Array.IndexOf(Alpha, character)];
                }
                else
                {
                    outputText += character;
                }
            }


            return outputText;
        }

        public static string DecipherArray(string plainText)
        {

            plainText = plainText.ToUpper();
            var outputText = string.Empty;
            foreach (var character in plainText)
            {
                if (cipherKey.Contains(character))
                {
                    //var index = Array.IndexOf(second, character);
                    outputText += Alpha[Array.IndexOf(cipherKey, character)];
                }
                else
                {
                    outputText += character;
                }
            }


            return outputText;
        }

        private static char[] ScrambleProperly()
        {
            var retried = 0;
            var outKey = Alpha.OrderBy(x => rnd.Next()).ToArray();
            while (TestKey(outKey))
            {
                outKey = Alpha.OrderBy(x => rnd.Next()).ToArray();
                retried++;
            }

            Console.WriteLine(retried);
            return outKey;
        }

        private static bool TestKey(char[] outKey)
        {
            for (int i = 0; i < Alpha.Length; i++)
            {
                if (Alpha[i] == outKey[i])
                {
                    return true;
                }
            }

            return false;
        }
    }
}