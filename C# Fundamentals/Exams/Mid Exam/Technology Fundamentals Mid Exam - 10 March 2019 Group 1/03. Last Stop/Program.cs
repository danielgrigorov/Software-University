using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string[] token = command.Split();

                string action = token[0];
                int firstNumber = 0;
                int secondNumber = 0;

                if (token.Length > 1)
                {
                     firstNumber = int.Parse(token[1]);
                }

                if (token.Length > 2)
                {
                     secondNumber = int.Parse(token[2]);
                }

                if (action == "Change" && list.Contains(firstNumber))
                {
                    int indexFirstNumber = list.IndexOf(firstNumber);
                    list[indexFirstNumber] = secondNumber;
                }

                else if (action == "Hide" && list.Contains(firstNumber))
                {
                    list.RemoveAll(x => x == firstNumber);
                }

                else if (action == "Switch" && list.Contains(firstNumber) && list.Contains(secondNumber))
                {
                    int indexFirstNumber = list.IndexOf(firstNumber);
                    int indexSecondNumber = list.IndexOf(secondNumber);

                    list[indexFirstNumber] = secondNumber;
                    list[indexSecondNumber] = firstNumber;
                }

                else if (action == "Insert" && firstNumber< list.Count && firstNumber >= -1)
                {
                    list.Insert(firstNumber +1, secondNumber);
                }

                else if (action == "Reverse")
                {
                    list.Reverse();
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
