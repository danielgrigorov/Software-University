using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 255;
            int tank = 0;

            for (int i = 1; i <= n; i++)
            {
                int quantity = int.Parse(Console.ReadLine());

                if (quantity <= capacity)
                {
                    capacity -= quantity;
                    tank += quantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(tank);
        }
    }
}
