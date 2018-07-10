using System;
using System.Linq;

namespace Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productsName = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            long[] quantity = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            decimal[] price = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();
            string[] input = Console.ReadLine().Split();
            while (input[0] != "done")
            {
                int index = Array.IndexOf(productsName, input[0]);
                if (quantity.Length - 1 < index)
                {
                    Console.WriteLine($"We do not have enough {string.Join("",input[0])}");
                }
                else if (quantity[index] <= 0)
                {
                    Console.WriteLine($"We do not have enough {string.Join("", input[0])}");
                }
                else
                {
                    Console.WriteLine($"{string.Join("",input[0])}"
                        + $" x {input[1]}"
                        + $" costs {(price[index] * long.Parse(input[1])):F2}");
                    quantity[index] -= long.Parse(input[1]);
                }
                
                input = Console.ReadLine().Split();
            }
        }
    }
}