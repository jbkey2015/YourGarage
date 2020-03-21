using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Cars
{
    class FastCar : Car
    {
        public FastCar(int fuel, int people, ColorOfVehicle color)
        {
            Fuel = fuel;
            People = people;
            Color = color;
        }

        public override void Driving(int miles)
        {
            Console.WriteLine($"You drive {miles} miles over the speed limit.");
        }
    }
}
