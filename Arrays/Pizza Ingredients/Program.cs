using System;
using System.Collections.Generic;

namespace Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int lenghtToMatch = int.Parse(Console.ReadLine());
            int counter = 0;
            var finalIngredients = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length == lenghtToMatch && counter < 10)
                {
                    
                    finalIngredients.Add(input[i]);
                    counter++;
                    Console.WriteLine($"Adding {input[i]}.");
                }
            }
            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", finalIngredients)}.");
        }
    }
}