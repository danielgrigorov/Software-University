using System;

namespace _07.Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday")
            {
                if (hours == 10 || hours == 11 || hours == 12 || hours == 13 || hours == 14 || hours == 15 || hours == 16 || hours == 17 || hours == 18)
                {
                    Console.WriteLine("open");
                }

                else
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }

            //else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday" || day == "Sunday")
            //    if (hours != 10 || hours != 11 || hours != 12 || hours != 13 || hours != 14 || hours != 15 || hours != 16 || hours != 17 || hours != 18)
            //    {
            //        Console.WriteLine("closed");
            //    }
            //    else if (day == "Sunday")
            //    {
            //        Console.WriteLine("closed");
            //    }
        }
    }
}
