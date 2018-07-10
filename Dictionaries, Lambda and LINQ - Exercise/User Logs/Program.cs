using System;
using System.Collections.Generic;
using System.Linq;

namespace User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var splittedInput = input.Split();
                var IP = splittedInput[0].Split('=');
                var message = splittedInput[1].Split('=');
                var user = splittedInput[2].Split('=');
                if (!dict.ContainsKey(user[1]))
                {
                    dict.Add(user[1], new Dictionary<string, int>());
                }
                if (!dict[user[1]].ContainsKey(IP[1]))
                {
                    dict[user[1]].Add(IP[1], 1);
                }
                else
                {
                    dict[user[1]][IP[1]]++;
                }
            }
            foreach (var item in dict.OrderBy(x => x.Key))
            {
                int counter = item.Value.Keys.Count();
                Console.WriteLine(item.Key + ": ");
                foreach (var kvp in item.Value)
                {
                    if (counter == 1)
                    {
                        Console.Write($"{kvp.Key} => {kvp.Value}.");
                    }
                    else
                    {
                        Console.Write($"{kvp.Key} => {kvp.Value}, ");
                    }
                    counter--;
                }
                Console.WriteLine();
            }
        }
    }
}