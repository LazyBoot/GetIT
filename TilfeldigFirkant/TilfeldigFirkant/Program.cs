using System;
using System.Threading;

namespace TilfeldigFirkant
{
    class Program
    {
        private static int _width = Console.WindowWidth-1;
        private static int _height = Console.WindowHeight-2;

        static void Main()
        {
            while (true)
            {
                var boxes = CreateBoxes();
                for (int i = 0; i < 200; i++)
                {
                    Show(boxes);
                    Thread.Sleep(50);
                }
                Console.WriteLine("(press enter for new. ctrl+c=exit)");
                Console.ReadLine();
            }
            // ReSharper disable once FunctionNeverReturns
        }

        private static Box[] CreateBoxes()
        {
            var random = new Random();
            var boxes = new Box[3];
            for (var i = 0; i < boxes.Length; i++)
            {
                boxes[i] = new Box(random, _width, _height);
            }
            return boxes;
        }

        private static void Show(Box[] boxes)
        {
            var screen = new Screen(_width, _height);
            foreach (var box in boxes)
            {
                box.Move(screen);
                screen.Add(box);
            }
            Console.Clear();
            screen.Show();
        }
    }
}
