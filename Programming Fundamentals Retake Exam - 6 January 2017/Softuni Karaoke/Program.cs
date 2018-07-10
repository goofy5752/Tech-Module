using System;
using System.Collections.Generic;
using System.Linq;

namespace Softuni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine().TrimStart().TrimEnd()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var songs = Console.ReadLine().TrimStart().TrimEnd()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var dict = new Dictionary<string, List<string>>();
            while (true)
            {
                var awards = Console.ReadLine().TrimStart().TrimEnd().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (awards[0] == "dawn")
                {
                    break;
                }
                var personName = awards[0];
                var song = awards[1];
                var award = awards[2];
                if (people.Contains(personName) && songs.Contains(song))
                {
                    if (!dict.ContainsKey(personName))
                    {
                        dict.Add(personName, new List<string>());
                    }
                    if (!dict[personName].Contains(award))
                    {
                        dict[personName].Add(award);
                    }
                }
            }
            var dict1 = dict.OrderBy(x => x.Value.Count).ThenBy(x => x.Key);
            if (dict.Count > 0)
            {
                foreach (var item in dict.OrderByDescending(p => p.Value.Count).ThenBy(n => n.Key))
                {
                    Console.WriteLine($"{item.Key}: {item.Value.Count} awards");
                    Console.WriteLine($"--{string.Join("\n" + "--", item.Value.OrderBy(x => x))}");
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}