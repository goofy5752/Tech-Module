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
            string input = Console.ReadLine();
            while (input != "done")
            {
                int index = Array.IndexOf(productsName, input);
                Console.WriteLine($"{input} costs: {price[index]}; Available quantity: {quantity[index]}");
                input = Console.ReadLine();
            }
        }
    }
}