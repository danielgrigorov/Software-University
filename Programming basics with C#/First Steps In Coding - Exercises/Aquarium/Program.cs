using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int wenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double djundjurii = double.Parse(Console.ReadLine());
            int volume = lenght * wenght * height;
            double liters = volume * 0.001;
            double percentage = djundjurii * 0.01;
            Console.WriteLine(liters * (1-percentage));

        }
    }
}
