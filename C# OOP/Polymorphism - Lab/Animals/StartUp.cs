using System;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Maria", "Whiskas");
            Animal dog = new Dog("Rex", "Meat");
            Animal animal = new Animal("Kiro", "Guuna");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
            Console.WriteLine(animal.ExplainSelf());

        }
    }
}
