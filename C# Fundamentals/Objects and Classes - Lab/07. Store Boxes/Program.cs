using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _07._Store_Boxes
{
    class Box
    {
        public int SerialNumber { get; set; }

        public string ItemName { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForBox { get; set; }

        public decimal TotalPrice { get; set; }
    }
}



namespace _07._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> itemBoxes = new List<Box>();


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] token = command.Split();

                int serialNumber = int.Parse(token[0]);
                string itemName = token[1];
                int itemQuantity = int.Parse(token[2]);
                decimal priceForBox = decimal.Parse(token[3]);

                decimal totalPrice = itemQuantity * priceForBox;

                Box box = new Box();

                box.SerialNumber = serialNumber;
                box.ItemName = itemName;
                box.ItemQuantity = itemQuantity;
                box.PriceForBox = priceForBox;
                box.TotalPrice = totalPrice;
                

                itemBoxes.Add(box);

            }

            List<Box> sortedBox = itemBoxes.OrderBy(x => x.TotalPrice).ToList();
            sortedBox.Reverse();

            foreach (Box box in sortedBox)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.ItemName} - ${box.PriceForBox:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.TotalPrice:f2}");
            }

        }
    }
}
