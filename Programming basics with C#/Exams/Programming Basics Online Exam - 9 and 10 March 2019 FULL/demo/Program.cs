using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "AaBbCcDd";
            char[] chars = s.ToCharArray();
            Console.WriteLine($"Original string: {s}");
            Console.WriteLine("Character array:");
            for (int ctr = 0; ctr < chars.Length; ctr++)
            {
                Console.WriteLine("   {0}: {1}", ctr, chars[ctr]);
            }
        }
    }
}
