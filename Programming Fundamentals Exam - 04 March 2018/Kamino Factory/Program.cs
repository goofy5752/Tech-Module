using System;
using System.Collections.Generic;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
                .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int counter = 0;
            var newList = new List<int>();
            while (numbers.ToString() != "Clone them!")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i].CompareTo(numbers[i + 1]) == 1)
                    {
                        counter++;
                    }
                    newList.Add(numbers[i]);
                }
                numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            }
        }
    }
}