using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Startup
    {
        static void Main(string[] args)
        {
            int sizes = int.Parse(Console.ReadLine());

            var jagged = new int[sizes][];

            for (int i = 0; i < sizes; i++)
            {
                var current = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jagged[i] = current;
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "END")
                {
                    break;
                }

                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int current = int.Parse(command[3]);

                if (row < 0 || col < 0 || row >= sizes)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (command[0] == "Add")
                    {
                        jagged[row][col] += current;
                    }
                    else if (command[0] == "Subtract")
                    {
                        jagged[row][col] -= current;
                    }
                }

            }
            foreach (int[] item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
