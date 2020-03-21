using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Watercrafts
{
    class JetSki : WaterCraft
    {
        public JetSki(int fuel, int passengers, ColorOfVehicle color)
        {
            Fuel = fuel;
            People = passengers;
            Color = color;
        }

        public void PullWaterSkier()
        {
            Console.WriteLine("You pull a water skier.");
        }
    }
}
