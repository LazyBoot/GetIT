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

        public Box(Random random, int maxX, int maxY)
        {
            X = random.Next(maxX - _minimumSize);
            Y = random.Next(maxY - _minimumSize);
            Width = random.Next(_minimumSize, maxX - X);
            Height = random.Next(_minimumSize, maxY - Y);
        }

        public Box(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public int GetTopRowY()
        {
            return Y;
        }

        public int GetBottomRowY()
        {
            return Y + Height;
        }
    }
}