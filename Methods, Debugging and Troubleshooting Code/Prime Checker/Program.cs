using System;
using System.Linq;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
                int n = int.Parse(Console.ReadLine());
                if (IsPrime(n))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
        }
        static bool IsPrime(int n)
        {
            if (n >= 0)
            {
                return Enumerable.Range(1, n).Where(x => n % x == 0)
                                 .SequenceEqual(new[] { 1, n });
            }

            return false;
        }
    }
}