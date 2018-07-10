using System;

namespace Sort_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Array.Sort(input);
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
