using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string srok = Console.ReadLine();
            string tip = Console.ReadLine();
            string mobilenINternet = Console.ReadLine();
            int meseci = int.Parse(Console.ReadLine());

            double price = 0;

            if (srok == "one")
            {
                if (tip == "Small")
                {
                    price = 9.98;
                }
                else if (tip == "Middle")
                {
                    price = 18.99;
                }
                else if (tip == "Large")
                {
                    price = 25.98;
                }
                else if (tip == "ExtraLarge")
                {
                    price = 35.99;
                }
            }
            else if (srok == "two")
            {
                if (tip == "Small")
                {
                    price = 8.58;
                }
                else if (tip == "Middle")
                {
                    price = 17.09;
                }
                else if (tip == "Large")
                {
                    price = 23.59;
                }
                else if (tip == "ExtraLarge")
                {
                    price = 31.79;
                }
            }
            if (mobilenINternet == "yes")
            {
                if (price <= 10)
                {
                    price += 5.5;
                }
                else if (price <= 30)
                {
                    price += 4.35;
                }
                else if (price >30)
                {
                    price += 3.85;
                }
                
            }
            if (srok == "two")
            {
                price *= 0.9625;
            }
            Console.WriteLine($"{price * meseci:F2} lv.");
        }
    }
}
