using System;
using System.Collections.Generic;
using System.Linq;

namespace Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] batteryCapacity = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            double[] batteryUsagePerHour = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            int hours = int.Parse(Console.ReadLine());
            var finalMAH = new List<double>();
            for (int i = 0; i < batteryUsagePerHour.Length; i++)
            {
                finalMAH.Add(batteryUsagePerHour[i] * hours);
            }
            for (int i = 0; i < batteryCapacity.Length; i++)
            {
                batteryCapacity[i] -= finalMAH[i];
                if (batteryCapacity[i] < 0)
                {
                    Console.WriteLine($"Battery {i + 1}: dead");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: {batteryCapacity[i]:F2} mAh ({(batteryCapacity[i] / (finalMAH[i] + batteryCapacity[i]) * 100.0):F2})%");
                }
            }
        }
    }
}