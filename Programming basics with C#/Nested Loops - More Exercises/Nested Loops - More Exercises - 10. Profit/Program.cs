using System;

namespace Nested_Loops___More_Exercises___10._Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int coins1lv = int.Parse(Console.ReadLine());
            int coins2lv = int.Parse(Console.ReadLine());
            int bills5lv = int.Parse(Console.ReadLine());
            int amount = int.Parse(Console.ReadLine());

            for (int i = 0; i <= coins1lv; i++)
            {
                for (int j = 0; j <= coins2lv; j++)
                {
                    for (int k = 0; k <= bills5lv; k++)
                    {
                        if (i * 1 + j * 2 + k * 5 == amount)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {amount} lv.");
                        }
                    }
                }
            }
        }
    }
}
