namespace Aquariums
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var aquarium = new Aquarium("Dinko", 1);
            var fish1 = new Fish("Petko");
            aquarium.Add(fish1);
            var result = aquarium.Report();

            Console.WriteLine(result);
        }
    }
}
