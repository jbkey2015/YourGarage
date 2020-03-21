using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.AirCrafts
{
    class Jet : AirCraft
    {
        public Jet(int fuel, int people, ColorOfVehicle color)
        {
            Fuel = fuel;
            People = people;
            Color = color;
        }

        public void ServeFood()
        {
            Console.WriteLine($"The stewardess serves food to {People} passengers.");
        }

        public override void Fly(int miles)
        {
            Console.WriteLine($"The plane soars {miles} miles in the sky!");
        }
    }
}
