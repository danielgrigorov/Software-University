using System;

namespace While_Loop___Exercise___03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double startMoney = double.Parse(Console.ReadLine());
            double currentMoney = 0;
            int counter = 0;
            int spendCounter = 0;

            while (startMoney < moneyNeeded)
            {
                string action = Console.ReadLine();
                currentMoney = double.Parse(Console.ReadLine());
                counter++;

                if (action == "save")
                {
                    startMoney += currentMoney;
                    spendCounter = 0;
                }

                if (action == "spend")
                {
                    startMoney -= currentMoney;
                    spendCounter++;
                }

                if (action == "spend" && currentMoney > startMoney)
                {
                    startMoney = 0;
                }
                if (spendCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{counter}");
                    break;
                }
                
            }
            if (startMoney >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {counter} days.");
            }
        }
    }
}
