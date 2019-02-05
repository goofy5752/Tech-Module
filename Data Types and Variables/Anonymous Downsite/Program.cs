using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            byte downWebsites = byte.Parse(Console.ReadLine());
            byte securityKey = byte.Parse(Console.ReadLine());
            decimal totalLoss = 0;
            for (int i = 0; i < downWebsites; i++)
            {
                string[] sites = Console.ReadLine().Split().ToArray();
                string site = sites[0];
                uint siteVisits = uint.Parse(sites[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(sites[2]);
                Console.WriteLine(site);
                totalLoss += siteVisits * siteCommercialPricePerVisit;
            }
            double securityKeyy = Math.Floor(Math.Pow(securityKey, downWebsites));
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine("Security Token: " + $"{securityKeyy:f0}");
        }
    }
}