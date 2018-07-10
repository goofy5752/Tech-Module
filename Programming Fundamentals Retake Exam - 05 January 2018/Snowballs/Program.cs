using System;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballCount = int.Parse(Console.ReadLine());
            double snowballValue = 0;
            double rememberValue = 0;
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            int snowballSnowL = 0;
            int snowballTimeL = 0;
            int snowballQualityL = 0;
            for (int i = 0; i < snowballCount; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                snowballValue = Math.Pow((snowballSnow / snowballTime), snowballQuality);
                if (rememberValue <= snowballValue)
                {
                    rememberValue = snowballValue;
                    snowballSnowL = snowballSnow;
                    snowballTimeL = snowballTime;
                    snowballQualityL = snowballQuality;
                }
            }
            Console.WriteLine($"{snowballSnowL} : {snowballTimeL} = {rememberValue} ({snowballQualityL})");
        }
    }
}