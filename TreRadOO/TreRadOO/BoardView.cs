using System;

namespace TreRadOO
{
    public class BoardView
    {
        public static void Show(BoardModel bm)
        {
            Console.Clear();

            Console.WriteLine("  a b c");
            Console.WriteLine(" ┌─────┐");
            Console.WriteLine($"1│{bm.Cells[0].GetSymbol()} {bm.Cells[1].GetSymbol()} {bm.Cells[2].GetSymbol()}│");
            Console.WriteLine($"2│{ bm.Cells[3].GetSymbol()} { bm.Cells[4].GetSymbol()} { bm.Cells[5].GetSymbol()}│");
            Console.WriteLine($"3│{bm.Cells[6].GetSymbol()} {bm.Cells[7].GetSymbol()} {bm.Cells[8].GetSymbol()}│");
            Console.WriteLine(" └─────┘");
        }
    }
}