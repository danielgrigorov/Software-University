using System;

namespace _01._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            double pensAmount = double.Parse(Console.ReadLine());
            double markersAmount = double.Parse(Console.ReadLine());
            double bleachAmount = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double price = pensAmount * 5.8 + markersAmount * 7.2 + bleachAmount * 1.2;

            double priceAfterDiscount = price * (100 - discount)/100;

            Console.WriteLine($"{priceAfterDiscount:f3}");
        }
    }
}
