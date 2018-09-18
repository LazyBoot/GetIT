using System;

namespace TilfeldigFirkant
{
    public class Box
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        private int _minimumSize = 3;
        public int RetningX { get; private set; }
        public int RetningY { get; private set; }

        public Box(Random random, int maxX, int maxY)
        {
            maxX -= 1;
            maxY -= 1;
            X = random.Next(maxX - _minimumSize);
            Y = random.Next(maxY - _minimumSize);
            Width = random.Next(_minimumSize, maxX - X);
            Height = random.Next(_minimumSize, maxY - Y);
            RetningX = random.Next(0, 100) < 50 ? 1 : -1;
            RetningY = random.Next(0, 100) < 50 ? 1 : -1;
        }

        public Box(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            var random = new Random();
            RetningX = random.Next(0, 100) < 50 ? 1 : -1;
            RetningY = random.Next(0, 100) < 50 ? 1 : -1;
        }

        public Box(int x, int y, int width, int height, int retningX, int retningY)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            RetningX = retningX;
            RetningY = retningY;
        }


        public int GetTopRowY()
        {
            return Y;
        }

        public int GetBottomRowY()
        {
            return Y + Height;
        }

        public void Move(Screen screen)
        {
            if (!(X > 0))
            {
                RetningX = 1;
            }
            if (!(X + Width < screen.Width - 1))
            {
                RetningX = -1;
            }

            if (!(Y > 0))
            {
                RetningY = 1;
            }

            if (!(Y + Height < screen.Height - 1))
            {
                RetningY = -1;
            }
            X += RetningX;
            Y += RetningY;
        }
    }
}