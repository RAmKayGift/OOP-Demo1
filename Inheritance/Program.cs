using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();


            vehicles.Add(new Car
            {
                Make = "VW",
                Model = "Polo",
                Year = 2022,
                DoorCount = 4
            });

            vehicles.Add(new Truck
            {
                Make = "Isuzu",
                Model = "F-Series",
                Year = 2019,
                PayloadTons = 8.5
            });

            vehicles.Add(new ElectricCar
            {
                Make = "Tesla",
                Model = "Model x",
                Year = 2023,
                DoorCount = 4,
                BatteryRangeKm = 500
            });

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.GetDescription());
            }

        }
    }
    
}
