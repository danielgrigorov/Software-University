using System;
using System.Collections.Generic;

namespace тест
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int number2 = 2;
            int number3 = 4;

            List<int> list = new List<int>();

            for (int i = 0; i < 2; i++)
            {
                list.Add(number);
                list.Add(number2);
                list.Add(number3);


            }

            string name = "kolio";

            foreach (var hui in list)
            {
                Console.WriteLine(name);
            }
        }
    }
}
