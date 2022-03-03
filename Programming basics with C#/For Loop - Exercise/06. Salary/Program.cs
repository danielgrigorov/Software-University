using System;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentSite = Console.ReadLine();

                if (currentSite == "Facebook")
                {
                    salary -= 150;
                }
                else if (currentSite == "Instagram")
                {
                    salary -= 100;
                }
                else if (currentSite == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    break;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine($"{salary}");
            }
        }
    }
}
