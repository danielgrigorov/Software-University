using System;

namespace _04._Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            if (number >= 16 && gender == "m")
            {
                Console.WriteLine("Mr.");
            }
            else if (number <16 && gender == "m")
            {
                Console.WriteLine("Master");
            }
            else if (number >= 16 && gender == "f")
            {
                Console.WriteLine("Ms.");
            }
            else
                Console.WriteLine("Miss");
            
        }
    }
}
