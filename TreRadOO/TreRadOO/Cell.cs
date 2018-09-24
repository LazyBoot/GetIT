using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreRadOO
{
    public class Cell
    {
        private CellOwner _content;

        public Cell()
        {
            _content = CellOwner.None;
        }

        public bool SetSymbol(CellOwner symbol)
        {
            if (_content != CellOwner.None) return false;

            _content = symbol;
            return true;
        }

        public CellOwner GetContent()
        {
            return _content;
        }
    }
}
