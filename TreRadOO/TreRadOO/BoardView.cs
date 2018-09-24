using System;

namespace TreRadOO
{
    public class BoardView
    {
        public static void Show(BoardModel bm)
        {
            Console.Clear();

            Console.WriteLine(
                "  a b c" + Environment.NewLine +
                " ┌─────┐" + Environment.NewLine +
                $"1│{GetSymbol(bm, 0)} {GetSymbol(bm, 1)} {GetSymbol(bm, 2)}│" + Environment.NewLine +
                $"2│{ GetSymbol(bm, 3)} { GetSymbol(bm, 4)} { GetSymbol(bm, 5)}│" + Environment.NewLine +
                $"3│{GetSymbol(bm, 6)} {GetSymbol(bm, 7)} {GetSymbol(bm, 8)}│" + Environment.NewLine +
                " └─────┘");
        }

        private static char GetSymbol(BoardModel bm, int cell)
        {
            var content = bm.Cells[cell].GetContent();

            if (content == CellOwner.Player1) return 'x';
            if (content == CellOwner.Player2) return 'o';
            return ' ';

        }
    }
}