using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.AirCrafts
{
    class Helecoptor : AirCraft
    {
        public Helecoptor(int fuel, int people, ColorOfVehicle color)
        {
            Fuel = fuel;
            People = people;
            Color = color;
        }

        public override void Land()
        {
            Console.WriteLine("The helecoptor sets down on the landing pad.");
        }
    }
}
