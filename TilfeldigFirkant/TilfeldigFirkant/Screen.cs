using System;

namespace TilfeldigFirkant
{
    public class Screen
    {
        private ScreenRow[] _rows;
        public readonly int Width;
        public readonly int Height;

        public Screen(int width, int height)
        {
            Height = height;
            Width = width;
            _rows = new ScreenRow[height];
            for (int row = 0; row < height; row++)
            {
                _rows[row] = new ScreenRow(width, 0);
            }
        }

        public void Add(Box box)
        {
            var firstY = box.GetTopRowY();
            var lastY = box.GetBottomRowY();
            _rows[firstY].AddTopRow(box.X, box.Width);
            _rows[lastY].AddBottomRow(box.X, box.Width);
            for (var row = firstY + 1; row < lastY; row++) // Remember, watch out for off-by-one errors! 
            {
                _rows[row].AddMiddleRow(box.X, box.Width);
            }
        }

        public void Show()
        {
            Console.Clear();
            foreach (var row in _rows)
            {
                row.Show();
            }
        }
    }
}