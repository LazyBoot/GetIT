using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UndervisningObjekter
{
    class Program
    {
        static void Main()
        {
            var place = new Place("Stavern", "Larvik", "Vestfold");

            var place2 = new Place("Rjukan", "Tinn", "Telemark");

            place.ShowPlace();
            place2.ShowPlace();
        }
    }
}
