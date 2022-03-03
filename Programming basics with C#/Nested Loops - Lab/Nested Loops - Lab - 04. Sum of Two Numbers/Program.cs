using System;

namespace Nested_Loops___Lab___04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int final = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int counter = 0;
            bool nomagicnumber = true;

            for (int i = start; i <= final; i++)
            {
                for (int j = start; j <= final; j++)
                {
                    counter++;
                    if (i + j == magic)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magic})");
                        nomagicnumber = false;
                        return;
                    }
                }
            }
            if (nomagicnumber == true)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }
        }
    }
}
