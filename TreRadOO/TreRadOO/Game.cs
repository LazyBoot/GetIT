namespace TreRadOO
{
    class Game
    {
        public static string Winner;

        public static bool CheckWin(BoardModel bm)
        {
            return CheckCells(0, 1, 2, bm)
                   || CheckCells(3, 4, 5, bm)
                   || CheckCells(6, 7, 8, bm)
                   || CheckCells(0, 3, 6, bm)
                   || CheckCells(1, 4, 7, bm)
                   || CheckCells(2, 5, 8, bm)
                   || CheckCells(0, 4, 8, bm)
                   || CheckCells(2, 4, 6, bm);

        }

        private static bool CheckCells(int cellIndex0, int cellIndex1, int cellIndex2, BoardModel bm)
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