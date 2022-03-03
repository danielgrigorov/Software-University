using System;

namespace _04._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int petici = 0;
            int chetvorki = 0;
            int troiki = 0;
            int dvoiki = 0;
            double totalGrades = 0;

            for (int i = 0; i < n; i++)
            {
                double currentGrade = double.Parse(Console.ReadLine());

                if (currentGrade <= 2.99)
                {
                    dvoiki++;
                }
                else if (currentGrade <= 3.99)
                {
                    troiki++;
                }
                else if (currentGrade <= 4.99)
                {
                    chetvorki++;
                }
                else
                {
                    petici++;
                }
                totalGrades+= currentGrade;
            }
            double averageGrades = totalGrades / n;

            Console.WriteLine($"Top students: {petici *1.0/n*100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {chetvorki*1.0/n*100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {troiki*1.0/n*100:f2}%");
            Console.WriteLine($"Fail: {dvoiki*1.0/n*100:f2}%");
            Console.WriteLine($"Average: {averageGrades:f2}");
        }
    }
}
