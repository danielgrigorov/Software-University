using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());
            double areaHall = (L * 100) * (W * 100);
            double wardrobe = wardrobeSide * wardrobeSide * 10000;
            double bench = areaHall / 10;
            double space = areaHall - wardrobe - bench;
            double end = space / 7040;
            Console.WriteLine(Math.Floor(end));

        }
    }
}
