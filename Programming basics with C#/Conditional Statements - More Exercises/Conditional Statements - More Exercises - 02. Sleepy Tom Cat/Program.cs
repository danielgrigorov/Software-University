using System;

namespace Conditional_Statements___More_Exercises___02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int countHolidayDays = int.Parse(Console.ReadLine());
            int countWorkingDays = 365 - countHolidayDays;

            int timeForPlay = countHolidayDays * 127 + countWorkingDays * 63;

            int diff = 30000 - timeForPlay;

            int hours = diff / 60;
            int minutes = diff - hours * 60;

            if (timeForPlay > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Abs(hours)} hours and {Math.Abs(minutes)} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Abs(hours)} hours and {Math.Abs(minutes)} minutes less for play");
            }
        }
    }
}
