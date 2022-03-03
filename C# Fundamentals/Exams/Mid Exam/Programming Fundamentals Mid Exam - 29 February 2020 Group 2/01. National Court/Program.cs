using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int questions = int.Parse(Console.ReadLine());

            int totalEmployees = firstEmployee + secondEmployee + thirdEmployee;

            int counter = 0;

            for (int i = 1; i < 10000; i++)
            {
                if (questions <= 0)
                {
                    break;
                }

                if (i %4 == 0)
                {
                    counter++;
                    continue;
                }

                questions -= totalEmployees;

                counter++;
            }
            Console.WriteLine($"Time needed: {counter}h.");
        }
    }
}
