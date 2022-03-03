using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int inputValue = 0;

            var result = new Dictionary<string, int>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "stop")
                {
                    break;
                }

                input = command;
                inputValue = int.Parse(Console.ReadLine());

                if (!result.ContainsKey(input))
                {
                    result[input] = inputValue;
                }
                else
                {
                    result[input] += inputValue;

                }
            }

            foreach (var resul in result)
            {
                Console.WriteLine($"{resul.Key} -> {resul.Value}");
            }
        }
    }
}
