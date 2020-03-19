using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Vehicle
    {
        public int Fuel { get; set; }
        public ColorOfVehicle Color { get; set; }
        public int People { get; set; }
        
        public virtual void Refuel(int gallons)
        {
            Console.WriteLine($"You need {gallons} to refuel.");
        }

        public virtual void Driving(int miles)
        {
            Console.WriteLine($"You traveled {miles} miles.");
        }
    }

    enum ColorOfVehicle
    {
        GoldenRod,
        Blue,
        Pink,
        MotherOfPearl,
        Black,
        Silver
    }
}
