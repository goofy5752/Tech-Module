using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootListElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var list = new List<int>();

            while (input != "stop")
            {
                if (input == "bang")
                {
                    list.Reverse();
                    double average = list.Average();
                    Console.WriteLine($"shot {string.Join("", list.Where(x => x < average).First())}");
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i]--;
                    }
                    if (list.Count == 1)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {list[0]}");
                    }
                }
                else
                {
                    list.Add(int.Parse(input));
                }
                input = Console.ReadLine();
            }
        }
    }
}