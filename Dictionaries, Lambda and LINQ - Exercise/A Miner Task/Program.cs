using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());
                if (dict.ContainsKey(input))
                {
                    dict[input] += quantity;
                }
                if (!dict.ContainsKey(input))
                {
                    dict.Add(input, quantity);
                }
                
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}