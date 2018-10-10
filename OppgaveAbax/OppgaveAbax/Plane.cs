using System;

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

        public override string ToString()
        {
            return $"{base.ToString()} Vingespenn: {WingSpan}m. lasteevne: {Capacity} tonn. Egenvekt: {TotalWeight} tonn";
        }

        public void Move()
        {
            Console.WriteLine($"Fly ({RegNumber}) bedt om å fly.");
        }
    }
}
