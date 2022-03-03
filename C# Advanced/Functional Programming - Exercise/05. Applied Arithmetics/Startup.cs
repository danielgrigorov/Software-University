using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ",input));
                }
                else if (command == "add")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        input[i] += 1;
                    }
                }
                else if (command == "subtract")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        input[i] -= 1;
                    }
                }

                else if (command == "multiply")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        input[i] *= 1;
                    }
                }

            }
        }
    }
}
