using System;
using System.Collections.Generic;
using YourGarage.AirCrafts;
using YourGarage.Cars;
using YourGarage.Watercrafts;

namespace YourGarage
{
    class Program
    {
        public static void Main()
        {
            // Build a collection of all vehicles that fly
            var jet = new Jet(200, 250, ColorOfVehicle.Silver);
            var helecopter = new Helecoptor(150, 4, ColorOfVehicle.Black);

            List<AirCraft> aircrafts = new List<AirCraft>();
            aircrafts.Add(jet);
            aircrafts.Add(helecopter);


            // With a single `foreach`, have each vehicle Fly()
            foreach (var aircraft in aircrafts)
            {
                aircraft.Fly(1000);
            }

            // Build a collection of all vehicles that operate on roads
            var fordtruck = new FordTruck(12, 5, ColorOfVehicle.Black);
            var fastcar = new FastCar(20, 5, ColorOfVehicle.Blue);

            List<Car> cars = new List<Car>();
            cars.Add(fordtruck);
            cars.Add(fastcar);

            // With a single `foreach`, have each road vehicle Drive()
            foreach (var car in cars)
            {
                car.Driving(50);
            }

            // Build a collection of all vehicles that operate on water
            var jetski = new JetSki(10, 1, ColorOfVehicle.MotherOfPearl);
            var boat = new Boat(0, 5, ColorOfVehicle.Blue);

            List<WaterCraft> watercrafts = new List<WaterCraft>();
            watercrafts.Add(jetski);
            watercrafts.Add(boat);

            // With a single `foreach`, have each water vehicle Drive()
            foreach (var watercraft in watercrafts)
            {
                watercraft.Driving(5);
            }

            Console.ReadKey();
        }
    }
}
