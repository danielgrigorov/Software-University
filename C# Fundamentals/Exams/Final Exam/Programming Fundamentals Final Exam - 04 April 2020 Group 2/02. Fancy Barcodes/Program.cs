using System;
using System.Text.RegularExpressions;
using System.Text;


namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string current = Console.ReadLine();

                string pattern = @"(@#+)(?<name>[A-Z][A-Za-z\d]{4,}[A-Z])@#+";

                if (!Regex.IsMatch(current, pattern))
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    string barcode = string.Empty;
                    string pattern2 = @"\d";

                    if (!Regex.IsMatch(current, pattern2))
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        MatchCollection collection = Regex.Matches(current, pattern2);

                        foreach (Match item in collection)
                        {
                            barcode += item;
                        }

                        Console.WriteLine($"Product group: {barcode}");
                    }
                }
            }
        }
    }
}
