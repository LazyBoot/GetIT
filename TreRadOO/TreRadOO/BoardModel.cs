using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TreRadOO
{
    public class BoardModel
    {
        public Cell[] Cells = new Cell[9];

        private readonly Random _rnd = new Random();

        public BoardModel()
        {
            for (var i = 0; i < Cells.Length; i++)
            {
                Cells[i] = new Cell();
            }
        }

        public CellOwner GetSymbol(int cell)
        {
            return Cells[cell].GetContent();
        }

	    private bool SetSymbol(string position, CellOwner symbol)
        {
            var col = char.ToLower(position[0]) - 'a';
            var row = Convert.ToInt32(position[1].ToString()) - 1;

            var cell = col + row * 3;

            if (cell >= Cells.Length)
                cell = -1;

            /**
            * var cell = -1;
            * if (row == "1")
            * {
            *     if (col == "a") cell = 0;
            *     else if (col == "b") cell = 1;
            *     else if (col == "c") cell = 2;
            * }
            * else if (row == "2")
            * {
            *     if (col == "a") cell = 3;
            *     else if (col == "b") cell = 4;
            *     else if (col == "c") cell = 5;
            * }
            * else if (row == "3")
            * {
            *     if (col == "a") cell = 6;
            *     else if (col == "b") cell = 7;
            *     else if (col == "c") cell = 8;
            * }
            */

            return SetSymbol(cell, symbol);
        }

	    public bool SetSymbol(int cell, CellOwner symbol)
        {
            if (cell == -1) return false;

            return Cells[cell].SetSymbol(symbol);
        }

        public bool SetPlayer1(string position)
        {
            return SetSymbol(position, CellOwner.Player1);
        }

        public bool SetPlayer2(string position)
        {
            return SetSymbol(position, CellOwner.Player2);
        }

        public void SetRandomPlayer2()
        {
            var freeCells = Cells.Select((cells,i) => new { i, cells})
                .Where(cell => cell.cells.GetContent() == CellOwner.None)
                .Select(t=> t.i).ToArray();

            if (freeCells.Length == 0) return;
            var randomCell = freeCells[_rnd.Next(0, freeCells.Length)];

            //int randomCell;
            //do
            //{
            //    randomCell = _rnd.Next(0, 9);
            //    Thread.Sleep(10);
            //} while (GetSymbol(randomCell) != CellOwner.None);

            SetSymbol(randomCell, CellOwner.Player2);
        }
    }
}