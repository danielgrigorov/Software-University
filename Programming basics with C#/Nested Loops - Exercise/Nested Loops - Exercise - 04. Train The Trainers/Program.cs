using System;

namespace Nested_Loops___Exercise___04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryAmount = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            double currentGradeAmount = 0;
            double presentationsCount = 0;
            double totalGrades = 0;

            while (input != "Finish")
            {
                for (int i = 0; i < juryAmount; i++)
                {
                    double currentGrade = double.Parse(Console.ReadLine());
                    currentGradeAmount += currentGrade;
                }
                double averageCurrentGrade = currentGradeAmount / juryAmount;
                Console.WriteLine($"{input} - {averageCurrentGrade:f2}.");
                presentationsCount++;
                totalGrades += averageCurrentGrade;
                currentGradeAmount = 0;
                
                input = Console.ReadLine();
            }
            double averageTotalGrades = totalGrades / presentationsCount;
            Console.WriteLine($"Student's final assessment is {averageTotalGrades:f2}.");
        }
    }
}
