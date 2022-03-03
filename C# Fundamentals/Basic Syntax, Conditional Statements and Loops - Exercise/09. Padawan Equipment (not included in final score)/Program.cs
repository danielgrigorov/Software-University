using System;

namespace _09._Padawan_Equipment__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsAmount = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalSabresPrice = (Math.Ceiling(studentsAmount *1.1) * sabrePrice);
            double totalSabresPrice2 = totalSabresPrice;

            double totalRobesPrice = studentsAmount * robePrice;

            int beltsDiscount = studentsAmount / 6;

            double totalBeltsPrice = (studentsAmount - beltsDiscount) * beltPrice;

            double totalExpenses = totalSabresPrice2 + totalRobesPrice + totalBeltsPrice;

            if (totalExpenses <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalExpenses:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalExpenses - budget:f2}lv more.");
            }
        }
    }
}
