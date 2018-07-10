using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());

            BigInteger finalResult = 1;
            for (int i = 1; i <= input; i++)
            {
                finalResult *= i;
            }
            Console.WriteLine(finalResult);
        }
    }
}