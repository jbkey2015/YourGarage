using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Watercrafts
{
    class Boat : WaterCraft
    {
        public Boat(int fuel, int people, ColorOfVehicle color)
        {
            Fuel = fuel;
            People = people;
            Color = color;
        }
    }
}
