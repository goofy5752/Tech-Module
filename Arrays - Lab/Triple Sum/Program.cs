using System;
using System.Linq;

namespace Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            long sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 1; j < input.Length; j++)
                {
                    sum = input[i] + input[j];
                    if (input.Contains(sum))
                    {
                        Console.WriteLine($"{input[i]} + {input[j]} == {sum}");
                    }
                }
            }
        }
    }
}