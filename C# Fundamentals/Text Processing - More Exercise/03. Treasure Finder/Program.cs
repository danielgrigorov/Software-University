using System;
using System.Text;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] key = Console.ReadLine().Split();


            while (true)
            {
                string current = Console.ReadLine();

                if (current == "find")
                {
                    break;
                }

                StringBuilder result = new StringBuilder();


                for (int i = 0; i < current.Length; i++)
                {

                    int hui = current[i];

                    if (i > key.Length-1)
                    {
                        result.Insert(i, (char)(hui - int.Parse(key[i%key.Length])));
                    }
                    else
                    {
                        result.Insert(i, (char)(hui - int.Parse(key[i])));
                    }
                }

                string treasure = string.Empty;
                string coordinates = string.Empty;

                string kur = result.ToString();

                int firstIndex = kur.IndexOf('&');
                int secondIndex = kur.LastIndexOf('&');
                int thirdIndex = kur.IndexOf('<');
                int fourthIndex = kur.IndexOf('>');

                treasure = kur.Substring(firstIndex + 1, secondIndex - firstIndex - 1);
                coordinates = kur.Substring(thirdIndex + 1, fourthIndex - thirdIndex - 1);

                Console.WriteLine($"Found {treasure} at {coordinates}");
            }
        }
    }
}
