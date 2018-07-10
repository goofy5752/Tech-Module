using System;
using System.Collections.Generic;
using System.Linq;

namespace Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int numberToFind = int.Parse(Console.ReadLine());
            var list = new List<long>();
            var indexes = new List<long>();
            long index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == numberToFind)
                {
                    indexes.Add(i);
                }
            }
            if (indexes.Count > 0)
            {
                index = indexes.Last();
                for (int i = 0; i < index; i++)
                {
                    list.Add(input[i]);
                }
                Console.WriteLine(list.Sum());
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}