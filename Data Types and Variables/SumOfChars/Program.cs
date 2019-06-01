using System;
using System.Collections.Generic;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 0; i < inputNumber; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                totalSum += letter;
            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
