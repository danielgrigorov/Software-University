using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7.__Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPumps = int.Parse(Console.ReadLine());

            var original = new Queue<int>();

            int index = 0;

            //Тук прочитам всички входни данни и ги записвам в опашка original
            for (int i = 0; i < countOfPumps; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                original.Enqueue(input[0]);
                original.Enqueue(input[1]);
            }

            // тук въртя всяка една двойка стойности от оригиналната опашка, като всяка я проверявам дали литрите, които ще заредя ще ми стигнат (> или =) до следващата бензиностанция. Ако не ми стигнат значи тази двойка стойности отива най-отзад в опашката. Ако обаче си хвана двойка стойности където литрите са достатъчни или повече от дистанцията, то тогава тази двойка с-сти може да ми е стартова и да обиколя целия кръг докато отново стигна до тях. За това във вътрешен цикъл започвам да проверявам всички останали двойки след началната дали горивото винаги ще ми е над нулата, защото ако е под значи няма да мога да стигна до следващата бензиностанция. При всяко завъртане на вътрешния цикъл (когато горивото е >=0) вадя по една двойко стойности докато свършат. След като copy опашката няма никакви елементи остава да проверя дали в leftFuel ми е останало гориво.
            while (true)
            {
                var copy = new Queue<int>(original);

                long litres = copy.Dequeue();
                long distance = copy.Dequeue();

                if (litres < distance)
                {
                    original.Enqueue(original.Dequeue());
                    original.Enqueue(original.Dequeue());
                }
                else if (litres >= distance)
                {
                    long leftFuel = litres - distance;

                    while (copy.Any())
                    {
                        var litresInternal = copy.Dequeue();
                        var distanceInternal = copy.Dequeue();

                        if (litresInternal + leftFuel >= distanceInternal)
                        {
                            leftFuel = litresInternal + leftFuel - distanceInternal;
                        }
                        else
                        {
                            original.Enqueue(original.Dequeue());
                            original.Enqueue(original.Dequeue());
                            leftFuel = -1;
                            break;
                        }
                    }

                    if (leftFuel >= 0)
                    {
                        Console.WriteLine(index);
                        break;
                    }
                }
                index++;
            }
        }
    }
}