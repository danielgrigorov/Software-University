using System;

namespace While_Loop___More_Exercises___02._Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalAmountNeeded = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int currentPrice = 0;
            double cashCounter = 0;
            double cardCounter = 0;
            double currentCounter = 0;
            double cashMoney = 0;
            double cardMoney = 0;

            while (input != "End")
            {
                currentCounter++;
                currentPrice = int.Parse(input);
                if (currentCounter % 2 == 1)
                {
                    if (currentPrice > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        cashCounter++;
                        cashMoney += currentPrice;
                        Console.WriteLine("Product sold!");
                    }
                }
                else if (currentCounter % 2 == 0)
                {
                    if (currentPrice < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        cardCounter++;
                        cardMoney += currentPrice;
                        Console.WriteLine("Product sold!");
                    }
                }
                if (cashMoney + cardMoney >= totalAmountNeeded )
                {
                    double averageCashMoney = cashMoney / cashCounter;
                    double averageCardMoney = cardMoney / cardCounter;
                    Console.WriteLine($"Average CS: {averageCashMoney:f2}");
                    Console.WriteLine($"Average CC: {averageCardMoney:f2}");
                    break;
                }
                
                input = Console.ReadLine();
            }
            if (input == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
