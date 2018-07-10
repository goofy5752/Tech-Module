using System;
using System.Linq;

namespace Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int regionsAmount = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());
            double totalValue = 0;
            for (int i = 0; i < regionsAmount; i++)
            {
                double[] raindropsCount = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();
                totalValue += raindropsCount[0] / raindropsCount[1];
            }
            if (density > 0)
            {
                Console.WriteLine($"{totalValue / density:F3}");
            }
            else
            {
                Console.WriteLine(totalValue);
            }
            
        }
    }
}