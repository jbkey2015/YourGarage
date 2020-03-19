using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class AirCraft : Vehicle
    {
        public override void Refuel(int gallons)
        {
            if(gallons <= Fuel)
            {
                Console.WriteLine($"You added {gallons} gallons of fuel.");
            }
            else
            {
                Console.WriteLine($"You added to many gallons to your plane.");
            }
        }

        public virtual void Fly(int miles)
        {
            Console.WriteLine($"You flew {miles} miles");
        }

        public virtual void Land()
        {
            Console.WriteLine("You landed the plane");
        }
    }
}
