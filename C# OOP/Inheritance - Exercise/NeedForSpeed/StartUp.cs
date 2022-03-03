namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            double kilometers = 25;

            SportCar car = new SportCar(100, 60);
            car.Drive(kilometers);
            System.Console.WriteLine(car.Fuel);
        }
    }
}
