using System;
using System.Linq;

namespace Array_Statistic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine($"Min = {n.Min()}");
            Console.WriteLine($"Max = {n.Max()}");
            Console.WriteLine($"Sum = {n.Sum()}");
            Console.WriteLine($"Average = {n.Average()}");
        }
    }
}