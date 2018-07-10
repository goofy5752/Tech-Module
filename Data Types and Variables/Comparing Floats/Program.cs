using System;

namespace Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double valueOne = double.Parse(Console.ReadLine());
            double valueTwo = double.Parse(Console.ReadLine());
            double difference = Math.Abs(valueOne - valueTwo);
            if (difference > 0.000001d)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}