using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList randomlist = new RandomList(2);

            Console.WriteLine(randomlist.Age);

            randomlist.Add("23");
            randomlist.Add("33");
            randomlist.Add("43");
            randomlist.Add("53");

            randomlist.RandomString();

            Console.WriteLine(randomlist);

        }
    }
}
