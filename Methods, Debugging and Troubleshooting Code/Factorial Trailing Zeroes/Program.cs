using System;
using System.Numerics;
using System.Text;

namespace Factorial_Trailing_Zeroes
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
            StringBuilder reversed = new StringBuilder();
            int counter = 0;
            for (int i = finalResult.ToString().Length - 1; i >= 0; i--)
            {
                reversed.Append(finalResult.ToString()[i]);
            }
            for (int i = 0; i < reversed.ToString().Length; i++)
            {
                if (reversed.ToString()[i] == '0')
                {
                    counter++;
                }
                else
                {
                    break;
                }
    
            }
            Console.WriteLine(counter);
        }
    }
}