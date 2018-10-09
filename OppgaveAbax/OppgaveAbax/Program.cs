using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppgaveAbax
{
    class Program
    {
        static void Main(string[] args)
        {
            var bil1 = new Car("NF123456", 147, VehicleType.LightCar, "green", 200);
            var bil2 = new Car("NF654321", 150, VehicleType.LightCar, "blue", 195);
            Console.WriteLine($"Det er {(bil1.Equals(bil2) ? "" : "ikke ")}samme bil");


        }
    }
}
