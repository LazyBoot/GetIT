using System;

namespace OppgaveAbax
{
    class Program
    {
        static void Main(string[] args)
        {
            var bil1 = new Car("NF123456", 147, VehicleType.LightCar, "green", 200);
            var bil2 = new Car("NF654321", 150, VehicleType.LightCar, "blue", 195);
            Console.WriteLine(bil1);
            Console.WriteLine(bil2);
            Console.WriteLine($"Det er {(bil1.Equals(bil2) ? "" : "ikke ")}samme bil");

            var fly = new Plane("LN1234", 1000, VehicleType.JetPlane, 30, 2, 10);
            Console.WriteLine(fly);
            
            fly.Move();
            bil1.Move();

            var boat = new Boat("ABC123", 100, 30, VehicleType.Boat, 500);
            Console.WriteLine(boat);
        }
    }
}
