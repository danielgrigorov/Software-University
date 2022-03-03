using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int totalEmployees = firstEmployee + secondEmployee + thirdEmployee;

            if (studentsCount == 0)
            {
                Console.WriteLine($"Time needed: 0h.");
                return;
            }

            for (int i = 1; i <= int.MaxValue; i++)
            {
                if (i %4 == 0)
                {
                    continue;
                }
                studentsCount -= totalEmployees;

                if (studentsCount <= 0)
                {
                    Console.WriteLine($"Time needed: {i}h.");
                    break;
                }
            }
        }
    }
}
