using System;
using System.Collections.Generic;
using System.Linq;

namespace Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfDragons = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string, Dictionary<string, long>>>();
            var dragonColor = "";
            var dragonName = "";
            long dragonHealth = 250;
            long dragonDMG = 45;
            long dragonArmor = 10;
            var input = new string[5];
            for (int i = 0; i < numbersOfDragons; i++)
            {
                input = Console.ReadLine().Split();
                dragonColor = input[0];
                dragonName = input[1];
                if (input[2] != "null")
                {
                    dragonDMG = long.Parse(input[2]);
                }
                else
                {
                    dragonDMG = 45;
                }
                if (input[3] != "null")
                {
                    dragonHealth = long.Parse(input[3]);
                }
                else
                {
                    dragonHealth = 250;
                }
                if (input[4] != "null")
                {
                    dragonArmor = long.Parse(input[4]);
                }
                else
                {
                    dragonArmor = 10;
                }
                if (dict.ContainsKey(dragonColor) && dict[dragonColor].ContainsKey(dragonName))
                {
                    dict[dragonColor][dragonName]["damage"] = dragonDMG;
                    dict[dragonColor][dragonName]["health"] = dragonHealth;
                    dict[dragonColor][dragonName]["armor"] = dragonArmor;
                }
                if (!dict.ContainsKey(dragonColor))
                {
                    dict.Add(dragonColor, new Dictionary<string, Dictionary<string, long>>());
                }
                if (!dict[dragonColor].ContainsKey(dragonName))
                {
                    dict[dragonColor].Add(dragonName, new Dictionary<string, long>());
                }
                if (!dict[dragonColor][dragonName].ContainsKey("damage"))
                {
                    dict[dragonColor][dragonName].Add("damage", dragonDMG);
                }
                if (!dict[dragonColor][dragonName].ContainsKey("health"))
                {
                    dict[dragonColor][dragonName].Add("health", dragonHealth);
                }
                if (!dict[dragonColor][dragonName].ContainsKey("armor"))
                {
                    dict[dragonColor][dragonName].Add("armor", dragonArmor);
                }
            }
            var finalDragonsDMG = new decimal[dict.Count].ToList();
            var finalDragonsHealth = new decimal[dict.Count].ToList();
            var finalDragonsArmor = new decimal[dict.Count].ToList();
            int counter = 0;
            foreach (var item in dict)
            {
                foreach (var kvp in item.Value)
                {
                    foreach (var kvp1 in kvp.Value)
                    {
                        if (kvp1.Key == "damage" && input[2] != "null")
                        {
                            finalDragonsDMG[counter] += kvp.Value["damage"];
                        }
                        else if (kvp1.Key == "health" && input[3] != "null")
                        {
                            finalDragonsHealth[counter] += kvp.Value["health"];
                        }
                        else if (kvp1.Key == "armor" && input[4] != "null")
                        {
                            finalDragonsArmor[counter] += kvp.Value["armor"];
                        }
                    }
                }
                counter++;
            }
            counter = 0;
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}::({finalDragonsDMG[counter] / item.Value.Keys.Count():F2}/{finalDragonsHealth[counter] / item.Value.Keys.Count():F2}/{finalDragonsArmor[counter] / item.Value.Keys.Count():F2})");
                foreach (var secondItem in item.Value.OrderBy(x => x.Key))
                {
                    var withoutComaCounter = secondItem.Value.Values.Count();
                    Console.Write($"-{secondItem.Key} -> ");
                    foreach (var thirdItem in secondItem.Value)
                    {
                        withoutComaCounter--;
                        if (withoutComaCounter == 0)
                        {
                            Console.Write($"{thirdItem.Key}: {thirdItem.Value}");
                        }
                        else
                        {
                            Console.Write($"{thirdItem.Key}: {thirdItem.Value}, ");
                        }
                    }
                    withoutComaCounter = item.Value.Values.Count();
                    Console.WriteLine();
                }
                counter++;
            }
        }
    }
}