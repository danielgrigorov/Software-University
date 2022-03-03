using System;

namespace _08._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            if (income > minSalary && averageGrade < 5.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income < minSalary && averageGrade > 4.5 && averageGrade < 5.5)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(0.35 * minSalary)} BGN");
            }

            else if (averageGrade >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(averageGrade * 25)} BGN");

            else if (income < minSalary && averageGrade >= 5.5)
                    if (0.35 * minSalary > 25 * averageGrade)
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(0.35 * minSalary)} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(25 * averageGrade)} BGN");
                    }

            }
        }
    }
}
