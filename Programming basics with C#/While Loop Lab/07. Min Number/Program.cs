using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int worstNumber = 99999999;

            while (input != "Stop")
            {
                int amount = int.Parse(input);
                if (amount < worstNumber)
                {
                    worstNumber = amount;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(worstNumber);
        }
    }
}
