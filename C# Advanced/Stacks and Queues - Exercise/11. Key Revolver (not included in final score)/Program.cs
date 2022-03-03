using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeGunBarrel = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>(locks);
            var stack = new Stack<int>(bullets);

            int value = int.Parse(Console.ReadLine());

            int counter = 0;

            int patroni = sizeGunBarrel;

            while (queue.Any())
            {
                int currentBullet = stack.Peek();
                int currentLock = queue.Peek();

                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    queue.Dequeue();
                    stack.Pop();
                }
                else
                {
                    Console.WriteLine("Ping!");
                    stack.Pop();
                }

                counter++;

                patroni--;

                if (stack.Count == 0 && queue.Any())
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {queue.Count}");
                    break;
                }


                if (patroni == 0 && stack.Count >0)
                {
                    Console.WriteLine("Reloading!");
                    patroni = sizeGunBarrel;
                }


                if (queue.Count == 0)
                {
                    Console.WriteLine($"{stack.Count} bullets left. Earned ${value - (counter * bulletPrice)}");
                }

                
                

                
            }
        }
    }
}
