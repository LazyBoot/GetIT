using System;
using System.Threading;

namespace TreRadOO
{
    class BoardModel
    {
        public char[] Cells = {
            ' ', ' ', ' ',
            ' ', ' ', ' ',
            ' ', ' ', ' '
        };

        private readonly Random _rnd = new Random();

        private bool SetChar(string position, char symbol)
        {
            var row = position.Substring(1, 1);
            var col = position.Substring(0, 1).ToLower();

            int cell = -1;
            if (row == "1")
            {
                if (col == "a") cell = 0;
                else if (col == "b") cell = 1;
                else if (col == "c") cell = 2;
            }
            else if (row == "2")
            {
                if (col == "a") cell = 3;
                else if (col == "b") cell = 4;
                else if (col == "c") cell = 5;
            }
            else if (row == "3")
            {
                if (col == "a") cell = 6;
                else if (col == "b") cell = 7;
                else if (col == "c") cell = 8;
            }

            if (Cells[cell] != ' ') return false;

            Cells[cell] = symbol;
            return true;
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
            var randomCell = _rnd.Next(0, 9);
            while (Cells[randomCell] != ' ')
            {
                Thread.Sleep(10);
                randomCell = _rnd.Next(0, 9);
            }

            Cells[randomCell] = 'o';
        }
    }
}