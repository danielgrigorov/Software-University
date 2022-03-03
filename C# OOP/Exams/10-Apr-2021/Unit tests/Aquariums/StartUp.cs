namespace Aquariums
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var aquarium = new Aquarium("Dinko", 1);

            var fish = new Fish("Sonic");

            aquarium.Add(fish);

            var result = aquarium.SellFish("Sonic");

            Console.WriteLine(result.Name);
        }
    }
}
