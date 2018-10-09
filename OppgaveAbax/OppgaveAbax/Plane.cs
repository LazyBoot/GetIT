using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppgaveAbax
{
    public class Plane : Vehicle
    {
        public int WingSpan;
        public int Capacity;
        public int TotalWeight;

        public Plane(string regNumber, int enginePower, VehicleType type, int wingSpan, int capacity, int totalWeight) 
            : base(regNumber, enginePower, type)
        {
            WingSpan = wingSpan;
            Capacity = capacity;
            TotalWeight = totalWeight;
        }
    }
}
