using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            if (line.Length %2 == 1)
            {
                int middleChar = (line.Length / 2);
                Console.WriteLine(line[middleChar]);
            }
            else
            {
                int middleChar1 = line.Length / 2;
                int middleChar2 = line.Length / 2 + 1;
                Console.WriteLine($"{line[middleChar1-1]}{line[middleChar2-1]}");
            }
        }
    }
}
