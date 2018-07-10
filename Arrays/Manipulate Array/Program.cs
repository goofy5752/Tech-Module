using System;
using System.Collections.Generic;
using System.Linq;

namespace Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());
            var listOfInput = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                listOfInput.Add(input[i]);
            }

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command.Length == 1)
                {
                    if (command[0] == "Distinct")
                    {
                        listOfInput = listOfInput.Distinct().ToList();
                    }
                    else
                    {
                        listOfInput.Reverse();
                    }
                }
                else
                {
                    Replace(int.Parse(command[1]), command[2], listOfInput);
                }
            }
            Console.WriteLine(string.Join(", ", listOfInput));

        }
        static string[] Distinct(string[] input)
        {
            string[] q = input.Distinct().ToArray();
            return q;
        }
        static void Replace(int n, string rename, List<string> input)
        {
            input[n] = rename;
        }
    }
}