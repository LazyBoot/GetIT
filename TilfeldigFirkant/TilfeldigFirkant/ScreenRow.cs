using System;
using System.Text;

namespace TilfeldigFirkant
{
    class ScreenRow
    {
        private ScreenCell[] _cells;

        public ScreenRow(int width, int startX)
        {
            _cells = new ScreenCell[width + startX];

            for (var index = 0; index < _cells.Length; index++)
            {
                _cells[index] = new ScreenCell();
            }
        }

        public void AddTopRow(int startX, int width)
        {
            _cells[startX].AddUpperLeftCorner();
            for (var cell = 1; cell < width; cell++) // Remember: Watch out for off-by-one errors!
            {
                _cells[startX + cell].AddHorizontal();
            }
            _cells[startX + width].AddUpperRightCorner();
        }

        public void AddBottomRow(int startX, int width)
        {
            _cells[startX].AddLowerLeftCorner();
            for (var cell = 1; cell < width; cell++) // Remember: Watch out for off-by-one errors!
            {
                _cells[startX + cell].AddHorizontal();
            }
            _cells[startX + width].AddLowerRightCorner();

        }

        public void AddMiddleRow(int startX, int width)
        {
            _cells[startX].AddVertical();
            _cells[startX + width].AddVertical();

        }

        public void Show()
        {
            var output = new StringBuilder();
            foreach (var cell in _cells)
            {
                output.Append(cell.GetCharacter());
            }

            Console.WriteLine(output);
        }
    }
}