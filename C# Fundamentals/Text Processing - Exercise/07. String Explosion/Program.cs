using System;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            int strength = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '>')
                {
                    strength += int.Parse(line[i + 1].ToString());

                    while (strength != 0)
                    {
                        if (i+1 < line.Length)
                        {
                            if (line[i + 1] != '>')
                            {
                                line = line.Remove(i + 1, 1);
                                strength -= 1;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                       
                    }
                }
            }
            Console.WriteLine(line);
        }
    }
}
