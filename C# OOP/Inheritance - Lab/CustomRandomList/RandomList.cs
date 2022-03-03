using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random rnd;
        private int age;

        public RandomList(int age)
        {
            this.rnd = new Random();
            this.Age = age;
        }

        public int Age
        {
            get => this.age;
            private set => this.age = value;
        }

        public string RandomString()
        {
            int index = rnd.Next(0, this.Count);
            string str = this[index];

            this.RemoveAt(index);
            Console.WriteLine(str);
            return str;
        }
    }
}
