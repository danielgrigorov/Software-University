using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();

            double wallet = 0;

            while (coins != "Start")
            {
                double currentCoins = double.Parse(coins);

                if (currentCoins != 0.1 && currentCoins != 0.2 && currentCoins != 0.5 && currentCoins != 1 && currentCoins != 2)
                {
                    Console.WriteLine($"Cannot accept {currentCoins}");
                }

                if (currentCoins == 0.1 || currentCoins == 0.2 || currentCoins == 0.5 || currentCoins == 1 || currentCoins == 2)
                {
                    wallet += currentCoins;
                }
                coins = Console.ReadLine();
            }

            string currentProduct = Console.ReadLine();


            while (currentProduct != "End")
            {

                if (currentProduct != "Nuts" && currentProduct != "Water" && currentProduct != "Crisps" && currentProduct != "Soda" && currentProduct != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }

                if (currentProduct == "Nuts")
                {
                    if (wallet >= 2)
                    {
                        Console.WriteLine($"Purchased nuts");
                        wallet -= 2;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (currentProduct == "Water")
                { 
                    if (wallet >= 0.7)
                    {
                        Console.WriteLine($"Purchased water");
                        wallet -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (currentProduct == "Crisps")
                {
                    if (wallet >= 1.5)
                    {
                        Console.WriteLine($"Purchased crisps");
                        wallet -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (currentProduct == "Soda")
                {
                    if (wallet >= 0.8)
                    {
                        Console.WriteLine($"Purchased soda");
                        wallet -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (currentProduct == "Coke")
                {
                    if (wallet >= 1.0)
                    {
                        Console.WriteLine($"Purchased coke");
                        wallet -= 1.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                currentProduct = Console.ReadLine();
            }
            Console.WriteLine($"Change: {wallet:f2}");
        }
    }
}
