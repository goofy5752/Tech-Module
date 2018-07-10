using System;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {first}");
            Console.WriteLine($"b = {second}");
            string tempoary = first;
            first = second;
            second = tempoary;
            Console.WriteLine("After:");
            Console.WriteLine($"a = {first}");
            Console.WriteLine($"b = {second}");
        }
    }
}