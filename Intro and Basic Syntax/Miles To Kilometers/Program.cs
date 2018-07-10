using System;

namespace Miles_To_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", input * 1.60934);
        }
    }
}
