using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int currentTime = hours * 60 + minutes + 30;

            int newHours = currentTime / 60;
            int newMinutes = currentTime - newHours * 60;

            if (newHours >23)
            {
                newHours = 0;
            }

            Console.WriteLine($"{newHours}:{newMinutes:d2}");
        }
    }
}
