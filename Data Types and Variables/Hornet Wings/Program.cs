using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            int flapsBeforeRest = int.Parse(Console.ReadLine());
            double distance = (wingFlaps / 1000) * distanceInMeters;
            double flapsPerSecond = wingFlaps / 100;
            double restPer5Sec = (wingFlaps / flapsBeforeRest) * 5;
            double totalSec = flapsPerSecond + restPer5Sec;
            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{totalSec} s.");
        }
    }
}