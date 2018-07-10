using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[1];
                var IP = input[0];
                var duration = int.Parse(input[2]);
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new Dictionary<string, int>());
                }
                if (!dict[name].ContainsKey(IP))
                {
                    dict[name][IP] = duration;
                }
                else
                {
                    dict[name][IP] += duration;
                }
            }
            foreach (var item in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {string.Join("",item.Value.Values.Sum())} [{string.Join(", ", item.Value.Keys.OrderBy(x => x))}]");
            }
        }
    }
}