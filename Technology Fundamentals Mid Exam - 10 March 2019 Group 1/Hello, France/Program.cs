using System;
using System.Collections.Generic;
using System.Linq;

namespace Hello__France
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            double budget = double.Parse(Console.ReadLine());
            double startBudget = budget;
            var finalPrice = new List<double>();
            double maxClothesPrice = 50.00;
            double maxShoesPrice = 35.00;
            double maxAccessoriesPrice = 20.50;

            for (int i = 0; i < input.Length; i++)
            {
                string[] splittedInput = input[i].Split("->");
                string wearType = splittedInput[0];
                double wearPrice = double.Parse(splittedInput[1]);
                if (wearType == "Clothes")
                {
                    if (wearPrice <= maxClothesPrice && budget >= wearPrice)
                    {
                        budget -= wearPrice;
                        finalPrice.Add(wearPrice * 1.4);
                    }
                }
                else if (wearType == "Shoes")
                {
                    if (wearPrice <= maxShoesPrice && budget >= wearPrice)
                    {
                        budget -= wearPrice;
                        finalPrice.Add(wearPrice * 1.4);
                    }
                }
                else
                {
                    if (wearPrice <= maxAccessoriesPrice && budget >= wearPrice)
                    {
                        budget -= wearPrice;
                        finalPrice.Add(wearPrice * 1.4);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", finalPrice.Select(x => $"{x:F2}")));
            Console.WriteLine($"Profit: {(finalPrice.Sum() + budget) - startBudget:F2}");
            if (finalPrice.Sum() + budget >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}