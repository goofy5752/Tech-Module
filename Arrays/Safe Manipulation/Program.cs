using System;
using System.Collections.Generic;
using System.Linq;

namespace Manipulate_Array
{
    internal class Program
    {
        private static IList<string> listOfInput = new List<string>();

        public static void Main(string[] args)
        {
            listOfInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            //for (int i = 0; i < input.Length; i++)
            //{
            //    listOfInput.Add(input[i]);
            //}
            var command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                if (command.Length == 1)
                {
                    if (command[0] == "Distinct")
                    {
                        listOfInput = listOfInput.Distinct().ToList();
                    }
                    else if (command[0] == "Reverse")
                    {
                        ReverseTheFock(listOfInput);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else if (command[0] == "Replace")
                {
                    Replace(int.Parse(command[1]), command[2], listOfInput);
                }
                else if (command[0] == "Change")
                {
                    Change(int.Parse(command[1]), int.Parse(command[2]), listOfInput);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(", ", listOfInput));

        }

        private static void ReverseTheFock(IList<string> list)
        {
            IList<string> reversed = new List<string>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                reversed.Add(list[i]);
            }
            listOfInput.Clear();
            listOfInput = reversed;
        }

        private static void Replace(int n, string rename, IList<string> input)
        {
            if (input.Count > n && n >= 0)
            {
                input[n] = rename;
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }

        private static void Change(int positionOfChange, int positionToChange, IList<string> input)
        {
            if (input.Count > positionOfChange && positionOfChange >= 0 && input.Count > positionToChange && positionToChange >= 0)
            {
                var rememberPosition = input[positionOfChange];
                input[positionOfChange] = input[positionToChange];
                input[positionToChange] = rememberPosition;
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}