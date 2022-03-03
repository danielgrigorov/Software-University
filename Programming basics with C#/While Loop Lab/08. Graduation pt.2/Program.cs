using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int level = 1;
            double sum = 0;
            int fails = 0;

            while (level <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    sum += grade;
                    level++;
                }
                else
                {
                    fails += 1;
                }
                if (fails > 1)
                {
                    Console.WriteLine($"{name} has been excluded at {level} grade");
                    break;
                }
            }
            double average = sum / 12;

            if (fails < 2)
            {

                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}
