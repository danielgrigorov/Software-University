using System;

namespace Nested_Loops___More_Exercises___05._Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int counter = 0;
            bool noNoMoreSpace = false;

            for (int i = 1; i <= men; i++)
            {
                for (int j = 1; j <= women; j++)
                {
                    if (counter >= capacity)
                    {
                        noNoMoreSpace = true;
                        break;
                    }
                    Console.Write($"({i} <-> {j}) ");
                    counter++;
                }
                if (noNoMoreSpace)
                {
                    break;
                }
            }
        }
    }
}
