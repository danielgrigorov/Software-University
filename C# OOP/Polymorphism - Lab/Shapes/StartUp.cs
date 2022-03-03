using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                Rectangle rectangle = new Rectangle(3, 4);
                Circle circle = new Circle(22);

                Console.WriteLine(rectangle.CalculateArea());
                Console.WriteLine(rectangle.CalculatePerimeter());
                Console.WriteLine(rectangle.Draw());

                Console.WriteLine(circle.CalculateArea());
                Console.WriteLine(circle.CalculatePerimeter());
                Console.WriteLine(circle.Draw());
            }
            catch (Exception ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            
            


        }
    }
}
