using System;
using System.Collections.Generic;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split();
            var dict = new Dictionary<string, int>();
            var dragon = "";
            bool isFound = true;
            while (isFound)
            {
                for (int i = 1; i <= input.Length; i += 2)
                {
                    if (!dict.ContainsKey(input[i]))
                    {
                        dict.Add(input[i], int.Parse(input[i - 1]));
                    }
                    else
                    {
                        dict[input[i]] += int.Parse(input[i - 1]);
                    }
                    if (dict[input[i]] > 250)
                    {
                        if (dict[input[i]].Equals("fragments"))
                        {
                            dragon = "Valanyr obtained!";
                            isFound = false;
                        }
                        else if (dict[input[i]].Equals("shards"))
                        {
                            dragon = "Shadowmourne obtained!";
                            isFound = false;
                        }
                        else
                        {
                            dragon = "Dragonwrath obtained!";
                            isFound = false;
                        }
                        dict[input[i]] -= 250;
                    }
                }
            }
            Console.WriteLine(dragon);
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}