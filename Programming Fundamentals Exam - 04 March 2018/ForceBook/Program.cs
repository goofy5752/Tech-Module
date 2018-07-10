using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var dict = new Dictionary<string, List<string>>();
            while (true)
            {

                var input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    break;
                }
                if (input.Contains("|"))
                {
                    var arguments = input.Split("|");

                    var key = arguments[0].TrimEnd();

                    var name = arguments[1].TrimStart();

                    if (!dict.ContainsKey(key))
                    {
                        dict.Add(key, new List<string>());
                    }
                    if (!dict.Any(x => x.Equals(name)))
                    {
                        dict[key].Add(name);
                    }
                }
                else
                {
                    var arguments = input.Split("->");

                    var name = arguments[0].TrimEnd();

                    var key = arguments[1].TrimStart();


                    if (dict.Values.Any(x=> x.Contains(name)))
                    {
                        string keyy = "";

                        foreach (var kvp in dict)
                        {
                            foreach (var item in kvp.Value)
                            {
                                if (item == name)
                                {
                                    keyy = kvp.Key;

                                    break;
                                }
                            }
                        }
                        dict[keyy].Remove(name);
                        dict[key].Add(name);
                        Console.WriteLine($"{name} joins the {key} side!");
                    }
                    else
                    {
                        dict[key].Add(name);
                        Console.WriteLine($"{name} joins the {key} side!");
                    }
                }
            }
            foreach (KeyValuePair<string, List<string>> kvp in dict.OrderBy(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (kvp.Value.Count() > 0)
                {
                    Console.WriteLine("Side: {0}, Members: {1}",
                   kvp.Key, string.Join("\n", kvp.Value.Count));
                    Console.WriteLine($"! {string.Join("\n" + "! ", kvp.Value.OrderBy(x => x))}");
                }
            }
        }
    }
}