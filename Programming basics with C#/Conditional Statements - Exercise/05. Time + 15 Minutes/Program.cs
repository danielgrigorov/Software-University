using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            

            if (minutes >=45 && hours != 23)
            {
                minutes = minutes - 60 + 15;
                hours += 1;
            }
            else if (minutes >=45 && hours == 23)
            {
                minutes = minutes - 60 + 15;
                hours = 0;
            }
            else
            {
                minutes += 15;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
