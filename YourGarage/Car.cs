﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Car : Vehicle
    {
        public override void Refuel(int gallons)
        {
            if (gallons <= Fuel)
            {
                Console.WriteLine($"You added {gallons} gallons of fuel.");
            }
            else
            {
                Console.WriteLine($"You added to many gallons to your plane.");
            }
        }

        public void Brake()
        {
            Console.WriteLine("You slowed down with the brake.");
        }
    }
}
