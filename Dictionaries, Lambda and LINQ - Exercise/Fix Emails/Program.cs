using System;
using System.Collections.Generic;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                var quantity = Console.ReadLine();
                if (!quantity.EndsWith("us") && !quantity.EndsWith("uk"))
                {
                    if (!dict.ContainsKey(input))
                    {
                        dict.Add(input, quantity);
                    }
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}