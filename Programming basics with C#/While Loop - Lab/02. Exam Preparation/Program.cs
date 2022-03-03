using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int unsatisfiedGrades = int.Parse(Console.ReadLine());
            string currentProblemName = Console.ReadLine();
            int currentProblemGrade = int.Parse(Console.ReadLine());

            double gradesTotalCount = 0;
            int counterBadResults = 0;
            double counter = 0;
            string lastProblem = String.Empty;

            while (currentProblemName != "Enough")
            {
                
                if (currentProblemGrade <= 4)
                {
                    counterBadResults++;
                }
                if (counterBadResults == unsatisfiedGrades)
                {
                    Console.WriteLine($"You need a break, {unsatisfiedGrades} poor grades.");
                    break;
                }
                gradesTotalCount += currentProblemGrade;
                counter++;
                lastProblem = currentProblemName;
                currentProblemName = Console.ReadLine();
                if (currentProblemName != "Enough")
                {
                    currentProblemGrade = int.Parse(Console.ReadLine());
                }
            }
            double average = gradesTotalCount / counter;

            if (currentProblemName == "Enough")
            {
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
