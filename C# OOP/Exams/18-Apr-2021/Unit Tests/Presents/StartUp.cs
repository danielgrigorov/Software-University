namespace Presents
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var bag = new Bag();

            var present = new Present("Dinko", 23);
            var present2 = new Present("Kiro", 7);

            bag.Create(present);
            bag.Create(present2);

            var result = bag.GetPresents();

            Console.WriteLine(result.Count);

            foreach (var resul in result)
            {
                Console.WriteLine(resul.Name);
            }
        }
    }
}
