using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreRadOO
{
    public class Cell
    {
        private char _symbol;

        public Cell()
        {
            _symbol = ' ';
        }

        public bool SetSymbol(char symbol)
        {
            if (_symbol != ' ') return false;

            _symbol = symbol;
            return true;
        }

        public char GetSymbol()
        {
            return _symbol;
        }
    }
}
