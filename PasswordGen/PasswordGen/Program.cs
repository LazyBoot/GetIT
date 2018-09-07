using System;
using System.IO;
using System.Reflection;

namespace PasswordGen
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            var noArgs = false;
            if (args.Length == 0)
            {
                Console.Write("Enter commandline arguments: ");
                args = Console.ReadLine()?.Split(' ');
                noArgs = true;
            }
            File.WriteAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\password.txt", "");
            var watch = System.Diagnostics.Stopwatch.StartNew();
#endif


            if (!Validation.IsValid(args))
            {
                ShowOptions();

#if DEBUG
                watch.Stop();
                Console.WriteLine(watch.ElapsedMilliseconds);
#endif
                return;
            }

            var password = RandomGeneration.GeneratePasswordFromPattern(args);
            //Console.WriteLine(password);

            File.AppendAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\password.txt", password + Environment.NewLine);

#if DEBUG
            watch.Stop();
            Console.WriteLine("Runtime: {0} ms", watch.ElapsedMilliseconds);

            if (noArgs)
            {
                Console.Write("Press any key to exit...");
                Console.ReadKey();
            }
#endif
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
