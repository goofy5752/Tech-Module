using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, string>>();
            var participants = "";
            while (true)
            {
                var input = Console.ReadLine().Split().ToList();
                if (input[0] == "Time")
                {
                    break;
                }
                var id = input[0];
                var eventName = input[1].ToCharArray();
                var finalEventName = "";
                for (int i = 1; i < eventName.Length; i++)
                {
                    finalEventName += eventName[i];
                }
                for (int i = 2; i < input.Count; i++)
                {
                    if (!input[i].Contains('@'))
                    {
                        continue;
                    }
                    else
                    {
                        participants += input[i] + " ";
                    }
                }
                if (!dict.ContainsKey(id))
                {
                    dict.Add(id, new Dictionary<string, string>());
                }
                if (!dict[id].ContainsKey(finalEventName) && dict[id].Keys.Count == 0)
                {
                    if (dict[id].Count == 1)
                    {
                        participants = "";
                        continue;
                    }
                    else
                    {
                        dict[id].Add(finalEventName, participants.TrimEnd());
                    }
                }
                else
                {
                    if (dict[id].ContainsKey(finalEventName))
                    {
                        dict[id][finalEventName] = participants.TrimEnd();
                    }
                    else
                    {
                        participants = "";
                        continue;
                    }
                }
                participants = "";
            }
            int[] participantsCount = new int[dict.Count];
            for (int i = 0; i < dict.Count; i++)
            {
                foreach (var item in dict)
                {
                    foreach (var kvp in item.Value)
                    {
                        var splittedValue = kvp.Value.Split();
                        participantsCount[i] = splittedValue.Length;
                    }
                }
            }
            foreach (var item in dict.OrderByDescending(x => x.Value.Values.Count))
            {
                int countt = 0;
                foreach (var count in item.Value)
                {
                    countt = count.Value.Split().Count();
                    if (countt == 1)
                    {
                        countt = 0;
                    }
                }
                Console.WriteLine($"{string.Join("",item.Value.Keys)} - {countt}");
                foreach (var kvp in item.Value.OrderBy(x => x.Key).ThenBy(x => x.Value).Distinct())
                {
                    var splittedValue = kvp.Value.Split().OrderBy(x => x).Distinct().ToArray();
                    for (int i = 0; i < splittedValue.Length; i++)
                    {
                        if (countt == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(splittedValue[i]);
                        }
                    }
                }
            }
        }
    }
}