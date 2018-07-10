using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();
            var name = "";
            var otherName = "";
            var role = "";
            var stats = 0;
            var statsToRemember = 0;
            var allRoles = "";
            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Ave")
                {
                    break;
                }
                if (input.Length == 5)
                {
                    name = input[0];
                    role = input[2];
                    allRoles += role + " ";
                    stats = int.Parse(input[4]);
                    statsToRemember = stats;
                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, new Dictionary<string, int>());
                    }
                    dict[name].Add(role, stats);
                    if (dict[name].ContainsKey(role))
                    {
                        if (stats > statsToRemember)
                        {
                            dict[name][role] = stats;
                        }
                    }
                }
                else
                {
                    name = input[0];
                    otherName = input[2];
                    if (dict.ContainsKey(name) && dict.ContainsKey(otherName))
                    {
                        if (dict.Keys.Contains(otherName))
                        {
                            var nameOneBool = false;
                            var roleToFight = "";
                            var splittedRoles = allRoles.Split();
                            for (int i = 0; i < splittedRoles.Length; i++)
                            {
                                if (dict[name].ContainsKey(splittedRoles[i]) && dict[otherName].ContainsKey(splittedRoles[i]))
                                {
                                    nameOneBool = true;
                                    roleToFight = splittedRoles[i];
                                }
                            }
                            if (nameOneBool && dict[name][roleToFight] > dict[otherName][roleToFight])
                            {
                                dict.Remove(otherName);
                            }
                            else if (nameOneBool && dict[name][roleToFight] < dict[otherName][roleToFight])
                            {
                                dict.Remove(name);
                            }
                        }
                    }
                }
            }
            foreach (var item in dict.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()} skill");
                foreach (var kvp in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {kvp.Key} <!> {kvp.Value}");
                }
            }
        }
    }
}