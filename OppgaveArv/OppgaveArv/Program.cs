using System;
using System.Threading;

namespace OppgaveArv
{
    class Program
    {
        private static int _width = 50;
        private static int _height = 20;

        static void Main(string[] args)
        {
            //var shapes = CreateRectangles();
            var shapes = CreateShapes();
            var n = 5;
            while (n-- > 0)
            {
                Show(shapes);
                foreach (var box in shapes)
                {
                    box.Move();
                }
                Thread.Sleep(500);
            }
        }

        private static Shape[] CreateShapes()
        {
            var random = new Random();
            var shapes = new Shape[5];
            shapes[0] = new Text(random, "testString", _width, _height);
            for (var i = 1; i < shapes.Length; i++)
            {
                switch (random.Next(0, 3))
                {
                    case 0:
                        shapes[i] = new Rectangle(random, _width, _height);
                        break;
                    case 1:
                        shapes[i] = new Text(random, "testString", _width, _height);
                        break;
                    default:
                        shapes[i] = new Triangle(random, _height);
                        break;
                }
            }
            return shapes;
        }

        private static void Show(Shape[] shapes)
        {
            Console.Clear();
            for (var row = 0; row < _height; row++)
            {
                for (var col = 0; col < _width; col++)
                {
                    var hasFoundCharacterToPrint = false;
                    foreach (var shape in shapes)
                    {
                        var character = shape.GetCharacter(row, col);
                        if (character != null)
                        {
                            Console.Write(character);
                            hasFoundCharacterToPrint = true;
                            break;
                        }
                    }
                    if (!hasFoundCharacterToPrint) Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

    }
}