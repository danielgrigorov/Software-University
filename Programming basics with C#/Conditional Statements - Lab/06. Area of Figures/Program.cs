using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            

            if (type == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine($"{area:f3}");
            }
            else if (type == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = a * b;
                Console.WriteLine($"{area:f3}");
            }
            else if (type == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                double area = Math.PI * a * a;
                Console.WriteLine($"{area:f3}");
            }
            else if (type == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = a * b / 2;
                Console.WriteLine($"{area:f3}");
            }
        }
    }
}
