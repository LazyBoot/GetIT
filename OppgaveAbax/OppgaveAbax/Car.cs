using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppgaveAbax
{
    public class Car : Vehicle
    {
        public string Colour { get; set; }
        public int TopSpeed { get; set; }

        public Car(string regNumber, int enginePower, VehicleType type, string colour, int topSpeed) : base(regNumber, enginePower, type)
        {
            Colour = colour;
            TopSpeed = topSpeed;
        }

        public override bool Equals(object obj)
        {
            if (obj?.GetType() == typeof(Car))
            {
                return RegNumber == (obj as Car).RegNumber;
            }

            return false;
        }
    }
}
