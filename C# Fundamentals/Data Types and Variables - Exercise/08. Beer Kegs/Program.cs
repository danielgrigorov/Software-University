using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double bestKeg = 0;
            string bestKegName = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double current = Math.PI * radius * radius * height;

                if (current > bestKeg)
                {
                    bestKeg = current;
                    bestKegName = model;
                }
            }
            Console.WriteLine(bestKegName);
        }
    }
}
