using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentsCount = double.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            double bonusAmount = double.Parse(Console.ReadLine());

            double maxBonus = 0;
            double maxStudentLectures = 0;
            double bestStudent = 0;

            double currentStudent = 0;

            double totalBonus = 0;

            for (int i = 1; i <= studentsCount; i++)
            {
                currentStudent = int.Parse(Console.ReadLine());

                totalBonus = currentStudent / lecturesCount * (5 + bonusAmount);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxStudentLectures = currentStudent;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxStudentLectures} lectures.");
        }
    }
}
