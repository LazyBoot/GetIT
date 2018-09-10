using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undervisning3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo1();
            //Demo2();

            DemoString();
        }

        private static void DemoString()
        {
            string a = "A";
            string b = "A";
        }

        private static void Demo2()
        {
            var boxA = new Box { Width = 20, Height = 30 };
            var boxB = new Box { Width = 20, Height = 30 };

            if (boxA == boxB) Console.WriteLine("A og B er like");
            else Console.WriteLine("A og B er ikke like");

            if (boxA.Height == boxB.Height) Console.WriteLine("A og B er like høye");
            else Console.WriteLine("A og B er ikke like høye");

        }

        private static void Demo1()
        {
            /* Reference types
             *  - objekter
             *  vs
             * Value types
             *  - int, float, bool, double, char
             */


            var boxA = new Box { Width = 20, Height = 30 };
            var boxB = new Box { Width = 5, Height = 7 };

            var c = boxA;
            c.Height = 99;
        }
    }
}
