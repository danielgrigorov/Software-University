using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            int counter = 0;
            bool hasEnergy = true;

            while (true)
            {
                string command = Console.ReadLine();

                if (counter %3 == 0)
                {
                    energy += counter;
                }

              

                if (command == "End of battle")
                {
                    break;
                }

                int distance = int.Parse(command);

                if (energy >= distance)
                {
                    energy -= distance;
                    counter++;
                }

                else if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {energy} energy");
                    hasEnergy = false;
                    break;
                }
            }

            if (hasEnergy)
            {
                Console.WriteLine($"Won battles: {counter}. Energy left: {energy}");
            }
        }
    }
}
