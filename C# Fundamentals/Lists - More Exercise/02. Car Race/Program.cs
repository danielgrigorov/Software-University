using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> leftRacer = new List<int>();
            List<int> rightRacer = new List<int>();

            for (int i = 0; i < list.Count/2; i++)
            {
                leftRacer.Add(list[i]);
            }

            for (int i = list.Count - 1; i > list.Count/2; i--)
            {
                rightRacer.Add(list[i]);
            }

            double resultLeftCar = 0;
            double resultRightCar = 0;

            for (int i = 0; i < leftRacer.Count; i++)
            {
                if (leftRacer[i] == 0)
                {
                    resultLeftCar *= 0.8;
                }
                else
                {
                    resultLeftCar += leftRacer[i];
                }
            }

            for (int i = 0; i < rightRacer.Count; i++)
            {
                if (rightRacer[i] == 0)
                {
                    resultRightCar *= 0.8;
                }
                else
                {
                    resultRightCar += rightRacer[i];
                }
            }
            if (resultLeftCar < resultRightCar)
            {
                Console.WriteLine($"The winner is left with total time: {resultLeftCar}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {resultRightCar}");

            }
        }
    }
}
