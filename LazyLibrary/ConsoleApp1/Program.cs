using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculate = LazyLibrary.CalculateAllTheThings.Calculate("50km/h in miles per minute");
            Console.WriteLine(calculate);
        }
    }
}
