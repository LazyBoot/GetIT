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
            //DemoString();
            DemoSideEffects();
        }

        private static void DemoSideEffects()
        {
            var box = new Box { Width = 20, Height = 30 };
            int i = 7;

            Console.WriteLine("Før: i=" + i);
            Console.WriteLine("Før: box.Height=" + box.Height);

            DoSomething(box, i);

            Console.WriteLine("Etter: i=" + i);
            Console.WriteLine("Etter: box.Height=" + box.Height);
        }

        private static void DoSomething(Box box, int i)
        {
            i += 10;
            //box.Height += 10;
            box = new Box() { Width = -1, Height = -1 };
        }

        private static void DemoString()
        {
            // String Immutable C#
            // String Interning C#

            string a = "A";
            string b = "A";

            if (a == b) Console.WriteLine("A og B er like");
            else Console.WriteLine("A og B er ikke like");

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
        private static void Demo3()
        {
            /* Reference types
             *  - objekter
             *  vs
             * Value types
             *  - int, float, bool, double, char
             */


            var boxA = new Box { Width = 20, Height = 30 };
            var boxB = new Box { Width = 5, Height = 7 };

            boxA = boxB;
        }
    }
}
