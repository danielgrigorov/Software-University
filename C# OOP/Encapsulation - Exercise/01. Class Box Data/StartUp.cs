using System;

namespace P01.BoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            

            try
            {
                Box box = new Box(l, w, h);
                box.GetSurfaceArea(l, w, h);
                box.GetLateralSurfaceArea(l, w, h);
                box.GetVolume(l, w, h);
            }
            catch (Exception ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
    }
}
