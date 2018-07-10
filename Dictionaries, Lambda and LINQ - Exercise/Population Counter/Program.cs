using System;
using System.Collections.Generic;
using System.Linq;

namespace Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "report")
                {
                    break;
                }
                var dataToUse = input.Split('|');
                if (!dict.ContainsKey(dataToUse[1]))
                {
                    dict.Add(dataToUse[1], new Dictionary<string, long>());
                }
                if (dict.ContainsKey(dataToUse[1]))
                {
                    dict[dataToUse[1]][dataToUse[0]] = long.Parse(dataToUse[2]);
                }
            }
            foreach (var item in dict.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value.Values.Sum()})");
                foreach (var kvp in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{kvp.Key}: {kvp.Value}");
                }
            }
        }
    }
}