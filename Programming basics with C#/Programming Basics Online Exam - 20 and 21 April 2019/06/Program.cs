using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int customersCount = int.Parse(Console.ReadLine());

            double currentBill = 0;

            int currentCounter = 0;

            double totalBills = 0;

            for (int i = 0; i < customersCount; i++)
            {
                string pokupka = Console.ReadLine();

                while (pokupka != "Finish")
                {
                    if (pokupka == "basket")
                    {
                        currentBill += 1.50;
                    }
                    else if (pokupka == "wreath")
                    {
                        currentBill += 3.80;
                    }
                    else if (pokupka == "chocolate bunny")
                    {
                        currentBill += 7.00;
                    }

                    currentCounter++;

                    pokupka = Console.ReadLine();
                }

                if (currentCounter %2 == 0)
                {
                    currentBill *= 0.8;
                }
                Console.WriteLine($"You purchased {currentCounter} items for {currentBill:f2} leva.");

                totalBills += currentBill;
                currentCounter = 0;
                currentBill = 0;
            }

            Console.WriteLine($"Average bill per client is: {totalBills /customersCount:f2} leva.");
        }
    }
}
