﻿namespace TreRadOO
{
    class Game
    {
        public static string Winner;

        public static bool CheckWin(BoardModel bm)
        {
            return CheckCells(bm, 0, 1, 2)
                   || CheckCells(bm, 3, 4, 5)
                   || CheckCells(bm, 6, 7, 8)
                   || CheckCells(bm, 0, 3, 6)
                   || CheckCells(bm, 1, 4, 7)
                   || CheckCells(bm, 2, 5, 8)
                   || CheckCells(bm, 0, 4, 8)
                   || CheckCells(bm, 2, 4, 6);

        }

        private static bool CheckCells(BoardModel bm, int cellIndex0, int cellIndex1, int cellIndex2)
        {
            var cell0 = bm.Cells[cellIndex0];
            var cell1 = bm.Cells[cellIndex1];
            var cell2 = bm.Cells[cellIndex2];

            if (cell0 == ' ' || cell1 != cell0 || cell2 != cell0) return false;

            Winner = cell0 == 'x' ? "Du" : "Datamaskinen";
            return true;
        }
    }
}