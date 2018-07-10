using System;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDMG = int.Parse(Console.ReadLine());
            int goshoDMG = int.Parse(Console.ReadLine());

            int goshoHealth = 100;
            int peshoHealth = 100;
            int counter = 0;
            while (true)
            {
                goshoHealth -= peshoDMG;
                if (goshoHealth <= 0 || goshoHealth <= 0)
                {
                    break;
                }
                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                counter++;

                if (counter % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }
                peshoHealth -= goshoDMG;
                if (peshoHealth <= 0 || goshoHealth <= 0)
                {
                    break;
                }
                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
               
                counter++;
                if (counter % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }
            }
            if (goshoHealth > 0)
            {
                Console.WriteLine($"Gosho won in {counter + 1}th round.");
            }
            else
            {
                Console.WriteLine($"Pesho won in {counter + 1}th round.");
            }
        }
    }
}