using System;

namespace Nested_Conditional_Statements___More_Exercises___07._School
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentsCount = int.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());

            string sportType = string.Empty;

            double price = 0;

            if (season == "Winter")
            {
                if (groupType == "boys")
                {
                    price = 9.6 * studentsCount * nightsCount;
                    sportType = "Judo";
                }
                else if (groupType == "girls")
                {
                    price = 9.6 * studentsCount * nightsCount;
                    sportType = "Gymnastics";
                }
                else if (groupType == "mixed")
                {
                    price = 10 * studentsCount * nightsCount;
                    sportType = "Ski";
                }
            }
            else if (season == "Spring")
            {
                if (groupType == "boys")
                {
                    price = 7.2 * studentsCount * nightsCount;
                    sportType = "Tennis";
                }
                else if (groupType == "girls")
                {
                    price = 7.2 * studentsCount * nightsCount;
                    sportType = "Athletics";
                }
                else if (groupType == "mixed")
                {
                    price = 9.5 * studentsCount * nightsCount;
                    sportType = "Cycling";
                }
            }
            else if (season == "Summer")
            {
                if (groupType == "boys")
                {
                    price = 15 * studentsCount * nightsCount;
                    sportType = "Football";
                }
                else if (groupType == "girls")
                {
                    price = 15 * studentsCount * nightsCount;
                    sportType = "Volleyball";
                }
                else if (groupType == "mixed")
                {
                    price = 20 * studentsCount * nightsCount;
                    sportType = "Swimming";
                }
            }
            if (studentsCount >= 50)
            {
                price *= 0.5;
            }
            else if (studentsCount >= 20 && studentsCount < 50)
            {
                price *= 0.85;
            }
            else if (studentsCount >= 10 && studentsCount < 20)
            {
                price *= 0.95;
            }
            Console.WriteLine($"{sportType} {price:f2} lv.");
        }
    }
}
