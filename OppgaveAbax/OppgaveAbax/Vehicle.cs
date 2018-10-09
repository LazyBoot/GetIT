using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppgaveAbax
{
    public class Vehicle
    {
        public string RegNumber;
        public int EnginePower;
        public VehicleType Type;

        public Vehicle(string regNumber, int enginePower, VehicleType type)
        {
            RegNumber = regNumber;
            EnginePower = enginePower;
            Type = type;
        }
    }
}
