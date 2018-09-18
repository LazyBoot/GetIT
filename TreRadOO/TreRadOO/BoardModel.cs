using System;
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

        private bool SetChar(string position, char symbol)
        {
            var row = Convert.ToInt32(position[1].ToString()) - 1;
            var col = (int)char.ToLower(position[0]) - 'a';

            var cell = col + row * 3;

            if (cell >= Cells.Length)
                cell = -1;

            //var cell = -1;
            //if (row == "1")
            //{
            //    if (col == "a") cell = 0;
            //    else if (col == "b") cell = 1;
            //    else if (col == "c") cell = 2;
            //}
            //else if (row == "2")
            //{
            //    if (col == "a") cell = 3;
            //    else if (col == "b") cell = 4;
            //    else if (col == "c") cell = 5;
            //}
            //else if (row == "3")
            //{
            //    if (col == "a") cell = 6;
            //    else if (col == "b") cell = 7;
            //    else if (col == "c") cell = 8;
            //}

            return SetChar(cell, symbol);
        }

        private bool SetChar(int cell, char symbol)
        {
            if (cell == -1) return false;

            return Cells[cell].SetSymbol(symbol);
        }

        public bool SetCross(string position)
        {
            return SetChar(position, 'x');
        }

        public bool SetCircle(string position)
        {
            return SetChar(position, 'o');
        }


        public void SetRandomCircle()
        {
            int randomCell;
            do
            {
                randomCell = _rnd.Next(0, 9);
                Thread.Sleep(10);
            } while (Cells[randomCell].GetSymbol() != ' ');

            SetChar(randomCell, 'o');
        }
    }
}