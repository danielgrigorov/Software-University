using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Startup
    {
        static void Main(string[] args)
        {
            var parking = new HashSet<string>();

            while (true)
            {
                var current = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string command = current[0];

                if (command == "END")
                {
                    break;
                }

                string regPlate = current[1];

                if (command == "IN")
                {
                    parking.Add(regPlate);
                }
                else
                {
                    parking.Remove(regPlate);
                }
            }

            if (parking.Any())
            {
                foreach (var item in parking)
                {
                    Console.WriteLine(item);
                }
            }

            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
