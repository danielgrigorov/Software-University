using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());

            List<int> currentLift = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < currentLift.Count; i++)
            {
                int currentSpace = 4 - currentLift[i];

                if (peopleWaiting >= currentSpace)
                {
                    currentLift[i] += currentSpace;
                    peopleWaiting -= currentSpace;
                }
                else if (peopleWaiting < currentSpace)
                {
                    currentLift[i] += peopleWaiting;
                    peopleWaiting = 0;
                }

                if ((currentLift.Count *4) - currentLift.Sum() > 0 && peopleWaiting == 0)
                {
                    Console.WriteLine("The lift has empty spots!");
                    Console.WriteLine(string.Join (" ", currentLift));
                    break;
                }

                else if (peopleWaiting >0 && currentLift.Sum() == (currentLift.Count) *4)
                {
                    Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                    Console.WriteLine(string.Join(" ", currentLift));
                    break;
                }
                else if (peopleWaiting == 0 && currentLift.Sum() == (currentLift.Count) * 4)
                {
                    Console.WriteLine(string.Join(" ", currentLift));
                    break;
                }
            }
        }
    }
}
