using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string make = "Trabant";
            string model = "Lilav";
            int year = 2021;
            double fuelQuantity = 222;
            double fuelConsumption = 8;

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car("Kon", model, year, fuelQuantity, fuelConsumption);

            Console.WriteLine(firstCar.Make);
            Console.WriteLine(secondCar.Make);
            Console.WriteLine(thirdCar.Make);
        }
    }
}
