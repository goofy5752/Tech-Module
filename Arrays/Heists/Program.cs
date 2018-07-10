using System;
using System.Collections.Generic;
using System.Linq;

namespace Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceOfJewelsAndGold = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[] LootAndHeistExpenses = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            long totalHeist = 0;
            long totalExpenses = 0;
            const char jewel = '%';
            const char gold = '$';

            while (LootAndHeistExpenses[0] != "Jail")
            {
                string splittedLoot = LootAndHeistExpenses[0];
                int expenses = int.Parse(LootAndHeistExpenses[1]);
                for (int i = 0; i < splittedLoot.Length; i++)
                {
                    if (splittedLoot[i] == jewel)
                    {
                        totalHeist += priceOfJewelsAndGold[0];
                    }
                    else if (splittedLoot[i] == gold)
                    {
                        totalHeist += priceOfJewelsAndGold[1];
                    }
                }
                totalExpenses += expenses;
                LootAndHeistExpenses = Console.ReadLine().Split();
            }
            if (totalHeist >= totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {Math.Abs(totalExpenses - totalHeist)}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(totalExpenses - totalHeist)}.");
            }
        }
    }
}