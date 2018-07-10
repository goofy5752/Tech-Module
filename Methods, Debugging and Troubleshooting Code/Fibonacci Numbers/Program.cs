using System;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Fibonacci(input);
        }
        static void Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i <= n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine(a);
        }
    }
}