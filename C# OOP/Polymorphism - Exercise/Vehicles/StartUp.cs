using System;
using System.Linq;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var carInput = Console.ReadLine().Split().ToArray();

            double carFuelQuantityInput = double.Parse(carInput[1]);
            double carFuelCosumptionInput = double.Parse(carInput[2]);

            var truckInput = Console.ReadLine().Split().ToArray();

            double truckFuelQuantityInput = double.Parse(truckInput[1]);
            double truckFuelCosumptionInput = double.Parse(truckInput[2]);

            Car car = new Car(carFuelQuantityInput, carFuelCosumptionInput);

            Truck truck = new Truck(truckFuelQuantityInput, truckFuelCosumptionInput);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var currentCommand = Console.ReadLine().Split().ToArray();

                string command = currentCommand[0];
                string vehicle = currentCommand[1];
                double amount = double.Parse(currentCommand[2]);

                if (command == "Drive")
                {
                    if (vehicle == "Car")
                    {
                        bool success = car.CanTravel(amount);

                        if (success)
                        {
                            car.Drive(amount);
                            Console.WriteLine($"Car travelled {amount} km");
                        }
                        else
                        {
                            Console.WriteLine($"Car needs refueling");
                        }
                    }
                    else if (vehicle == "Truck")
                    {
                        bool success = truck.CanTravel(amount);

                        if (success)
                        {
                            truck.Drive(amount);
                            Console.WriteLine($"Truck travelled {amount} km");
                        }
                        else
                        {
                            Console.WriteLine($"Truck needs refueling");
                        }
                    }
                }

                else if (command == "Refuel")
                {
                    if (vehicle == "Car")
                    {
                        car.Refuel(amount);
                    }
                    else if (vehicle == "Truck")
                    {
                        truck.Refuel(amount);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQunatity:f2}");

            Console.WriteLine($"Truck: {truck.FuelQunatity:f2}");

        }
    }
}
