using System;

namespace Nested_Conditional_Statements___More_Exercises___03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrizantemiCount = int.Parse(Console.ReadLine());
            int roziCount = int.Parse(Console.ReadLine());
            int laletaCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());

            double price = 0;

            if (season == "Spring" || season == "Summer")
            {
                price = hrizantemiCount * 2 + roziCount * 4.1 + laletaCount * 2.5;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                price = hrizantemiCount * 3.75 + roziCount * 4.5 + laletaCount * 4.15;
            }
            if (holiday == 'Y')
            {
                price *= 1.15;
            }
            if (season == "Spring" && laletaCount > 7)
            {
                price *= 0.95;
            }
            if (season == "Winter" && roziCount >= 10)
            {
                price *= 0.9;
            }
            if (hrizantemiCount + roziCount + laletaCount > 20)
            {
                price *= 0.8;
            }
            price += 2;
            Console.WriteLine($"{price:f2}");
        }
    }
}
