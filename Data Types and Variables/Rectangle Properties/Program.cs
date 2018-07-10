using System;

namespace Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cord1 = double.Parse(Console.ReadLine());
            double cord2 = double.Parse(Console.ReadLine());

            Console.WriteLine(2 * (cord1 + cord2));
            Console.WriteLine(cord1 * cord2);
            Console.WriteLine(Math.Sqrt(((Math.Pow(cord1, 2)) + Math.Pow(cord2, 2))));
        }
    }
}