using System;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float totalHours = (hours * 3600) + seconds + (minutes * 60);
            float metersPerSecond = distanceInMeters / totalHours;
            double kilometersPerHour = metersPerSecond * 3.6;
            double milesPerHour =  (distanceInMeters / 1609) / (totalHours / 3600);
            Console.WriteLine($"{metersPerSecond:F6}");
            Console.WriteLine($"{kilometersPerHour:F6}");
            Console.WriteLine($"{milesPerHour:F6}");
        }
    }
}