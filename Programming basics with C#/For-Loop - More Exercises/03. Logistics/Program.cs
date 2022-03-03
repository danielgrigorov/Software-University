using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLoads = 0;
            int bus = 0;
            int truck = 0;
            int train = 0;

            for (int i = 0; i < n; i++)
            {
                int currentLoad = int.Parse(Console.ReadLine());

                if (currentLoad <= 3)
                {
                    bus += currentLoad;
                }
                else if (currentLoad <= 11)
                {
                    truck += currentLoad;
                }
                else
                {
                    train += currentLoad;
                }
                sumLoads += currentLoad;
            }
            int totalPrice = bus * 200 + truck * 175 + train * 120;
            double averagePrice = totalPrice * 1.0 / sumLoads;

            Console.WriteLine($"{averagePrice:F2}");
            Console.WriteLine($"{bus *1.0 / sumLoads * 100:f2}%");
            Console.WriteLine($"{truck *1.0 / sumLoads * 100:f2}%");
            Console.WriteLine($"{train *1.0 / sumLoads * 100:f2}%");
        }
    }
}
