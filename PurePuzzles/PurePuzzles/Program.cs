using System;

namespace PurePuzzles
{
    internal class Program
    {
        private static void Main()
        {
            Shapes.DrawShapes();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);

            WordStats.ShowWordStats();
        }
    }
}
