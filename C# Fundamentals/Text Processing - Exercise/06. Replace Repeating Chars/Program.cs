using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            for (int i = 0; i < line.Length; i++)
            {
                char current = line[i];

                while (i + 1 < line.Length && current == line[i + 1])
                {
                    line = line.Remove(i + 1, 1);

                }
            }
            Console.WriteLine(line);
        }
    }
}
