using System;

namespace Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double picturesTaken = double.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            double filterFaction = double.Parse(Console.ReadLine());
            int timeNeededToFilter = int.Parse(Console.ReadLine());

            double filteredPictures = Math.Ceiling(picturesTaken * (filterFaction / 100));
            double totalTime = (picturesTaken * filterTime) + (filteredPictures * timeNeededToFilter);

            TimeSpan finalTime = TimeSpan.FromSeconds(totalTime);
            string str = finalTime.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(str);
        }
    }
}