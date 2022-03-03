using System;

namespace House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double xHeightOfTheHouse = double.Parse(Console.ReadLine());
            double yLenghtOfTheSideWall = double.Parse(Console.ReadLine());
            double hHeightOfTheRoofTriangle = double.Parse(Console.ReadLine());
            double areaSideWall = xHeightOfTheHouse * yLenghtOfTheSideWall;
            double areaWindow = 1.5 * 1.5;
            double bothSides = 2 * areaSideWall - 2 * areaWindow;
            double backSide = xHeightOfTheHouse * xHeightOfTheHouse;
            double door = 1.2 * 2;
            double totalFrontAndRear = 2 * backSide - door;
            double totalArea1 = bothSides + totalFrontAndRear;
            double green = totalArea1 / 3.4;
            double roofBig = 2 * xHeightOfTheHouse * yLenghtOfTheSideWall;
            double roofSmall = 2 * (xHeightOfTheHouse * hHeightOfTheRoofTriangle / 2);
            double totalArea2 = roofBig + roofSmall;
            double red = totalArea2 / 4.3;
            Console.WriteLine($"{green:f2}");
            Console.WriteLine($"{red:f2}");



        }
    }
}
