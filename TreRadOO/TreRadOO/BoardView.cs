using System;

namespace TreRadOO
{
    class BoardView
    {
        public static void Show(BoardModel bm)
        {
            Console.WriteLine("  a b c");
            Console.WriteLine(" ┌─────┐");
            Console.WriteLine($"1│{bm.Cells[0]} {bm.Cells[1]} {bm.Cells[2]}│");
            Console.WriteLine($"2│{ bm.Cells[3]} { bm.Cells[4]} { bm.Cells[5]}│");
            Console.WriteLine($"3│{bm.Cells[6]} {bm.Cells[7]} {bm.Cells[8]}│");
            Console.WriteLine(" └─────┘");
        }
    }
}