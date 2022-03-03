using System;

namespace CustomStack
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();

            stackOfStrings.Push("petko");
            stackOfStrings.Push("kiro");
            stackOfStrings.Push("dobri");
            stackOfStrings.Push("Stoqn");

            Console.WriteLine(stackOfStrings.IsEmpty());

            Console.WriteLine(stackOfStrings.Count);

            foreach (var item in stackOfStrings)
            {
                Console.WriteLine(item);
            }
        }
    }
}
