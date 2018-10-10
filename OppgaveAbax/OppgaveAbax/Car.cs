using System;

namespace OppgaveAbax
{
    public class Car : Vehicle
    {
        public string Colour;
        public int TopSpeed;

        public Car(string regNumber, int enginePower, VehicleType type, string colour, int topSpeed) : base(regNumber, enginePower, type)
        {
            Colour = colour;
            TopSpeed = topSpeed;
        }

        public override bool Equals(object obj)
        {
            if (obj?.GetType() == typeof(Car))
            {
                return RegNumber == ((Car)obj).RegNumber;
            }

            return false;
        }

        public void Move()
        {
            Console.WriteLine($"Bil ({RegNumber}) bedt om å kjøre.");
        }

        public override string ToString()
        {
            return $"{base.ToString()} Farge: {Colour}. Topphastighet: {TopSpeed} {TopSpeedUnit}.";
        }
    }
}
