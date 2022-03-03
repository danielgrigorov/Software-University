using System;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                for (int j = 0; j < line[i].Length; j++)
                {
                    result.Append(line[i]);
                }
            }

            Console.WriteLine(result);
        }
    }
}
