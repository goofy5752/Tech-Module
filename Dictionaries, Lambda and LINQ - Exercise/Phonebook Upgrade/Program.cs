﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            var dict = new Dictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    dict[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    if (dict.ContainsKey(input[1]))
                    {
                        Console.WriteLine(input[1] + " -> " + dict[input[1]]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                if (input[0] == "ListAll")
                {
                    foreach (var item in dict.OrderBy(x => x.Key).ThenBy(x => x.Value.Length))
                    {
                        Console.WriteLine(item.Key + " -> " + item.Value);
                    }
                }
                input = Console.ReadLine().Split();
            }
        }
    }
}