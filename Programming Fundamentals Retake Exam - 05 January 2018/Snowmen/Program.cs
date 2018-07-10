using System;
using System.Linq;

namespace Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > input.Count)
                {
                    input[i] = input[i] % input.Count;
                }
                if (Math.Abs(i - input[i]) % 2 == 0)
                {
                    if (i.Equals(input[i]))
                    {
                        Console.WriteLine($"{input[i]} performed harakiri");
                        input.RemoveAt(i);
                    }
                    Console.WriteLine($"{i} x {input[i]} -> {i} wins");
                }
                else if (Math.Abs(i - input[i]) % 2 == 1)
                {
                    Console.WriteLine($"{i} x {input[i]} -> {input[i]} wins");
                }
            }
        }
    }
}