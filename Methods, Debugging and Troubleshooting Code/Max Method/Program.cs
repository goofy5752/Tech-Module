using System;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            GetMaxNum(a, c);
        }
        static void GetMaxNum(int a, int b)
        {
            Console.WriteLine(Math.Max(a, b)); 
        }
    }
}