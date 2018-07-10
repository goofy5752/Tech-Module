using System;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double input2 = double.Parse(Console.ReadLine());

            double result = input * input2;

            Console.WriteLine("{0:F2}", result);
        }
    }
}