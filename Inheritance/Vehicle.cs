using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    
        class Vehicle 
        { 
            public string Make { get; set; }

            public string Model { get; set; }
            public int Year { get; set; }

            public virtual string GetDescription()
            {
                return Year + " " + Make + " " + Model;
            }   
        }

        class Car : Vehicle
        {
            public int DoorCount { get; set; }

            public override string GetDescription()
            {
                return Year + " " + Make + " " + Model + " - Doors: " + DoorCount;
            } 
        }

        class Truck : Vehicle
        {
            public double PayloadTons { get; set; }

            public override string GetDescription()
            {
                return Year + " " + Make + " " + Model + " - Payload: " + PayloadTons + " tons";
            }
        }

        // sealed means no other class can inherit from ElectricCar.
        sealed class ElectricCar : Car
        {
            public int BatteryRangeKm { get; set; }

            public override string GetDescription()
            {
                return Year + " " + Make + " " + Model +" , Doors: " + DoorCount +" , Battery Range: " + BatteryRangeKm + " km";
            }
        }
    }

