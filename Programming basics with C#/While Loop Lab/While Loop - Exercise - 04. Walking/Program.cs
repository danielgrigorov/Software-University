using System;

namespace While_Loop___Exercise___04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentSteps = Console.ReadLine();
            double totalSteps = 0;

            while (currentSteps != "Going home")
            {
                double currentAmount = double.Parse(currentSteps);
                totalSteps += currentAmount;
                if (totalSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
                    break;
                }

                currentSteps = Console.ReadLine();

            }
            if (currentSteps == "Going home")
            {

                double stepsToHome = double.Parse(Console.ReadLine());
                totalSteps += stepsToHome;

                if (totalSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
                }
            }
        }
    }
}
