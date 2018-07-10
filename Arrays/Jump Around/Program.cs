using System;
using System.Linq;

namespace Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int totalValue = 0;
            int currentIndex = 0;
            //while (true)
            //{
            //    int currentValue = numbers.ElementAt(currentIndex);
            //    totalValue += currentValue;
            //    // TODO: Right check
            //    if (currentIndex + currentValue < numbers.Length)
            //    {

            //    }
            //    // TODO: Left check
            //    else if (currentIndex + currentValue >= 0)
            //    {

            //    }
            //    // COMPLETED: break the while loop
            //    else
            //    {
            //        break;
            //    }
            //}

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers.Length)
                {
                    totalValue += numbers[i];
                    i = numbers[i];
                }
                else if () ;
            }
            Console.WriteLine(totalValue);
        }
    }
}