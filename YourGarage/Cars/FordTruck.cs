using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Cars
{
    class FordTruck : Car
    {
        public FordTruck(int fuel, int people, ColorOfVehicle color)
        {
            Fuel = fuel;
            People = people;
            Color = color;
        }

        public void FourWheelDrive()
        {
            Console.WriteLine("It has four wheel drive.");
        }
    }
}
