using System;
using System.Linq;

namespace Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                string commandType = command[0];
                if (commandType == "Switch")
                {
                    int number1 = int.Parse(command[1]);
                    int number2 = int.Parse(command[2]);

                    if (inputNumbers.Contains(number1) && 
                        inputNumbers.Contains(number2))
                    {
                        int element1Position = inputNumbers.IndexOf(number1);
                        int element2Position = inputNumbers.IndexOf(number2);
                        inputNumbers.RemoveAt(element1Position);
                        inputNumbers.Insert(element1Position, number2);
                        inputNumbers.RemoveAt(element2Position);
                        inputNumbers.Insert(element2Position, number1);
                    }
                }
                else if (commandType == "Hide")
                {
                    if (inputNumbers.Contains(int.Parse(command[1])))
                    {
                        inputNumbers.Remove(int.Parse(command[1]));
                    }
                }
                else if (commandType == "Reverse")
                {
                    inputNumbers.Reverse();
                }
                else if (commandType == "Change")
                {
                    if (inputNumbers.Contains(int.Parse(command[1])))
                    {
                        int element1Position = inputNumbers.IndexOf(int.Parse(command[1]));
                        inputNumbers.RemoveAt(element1Position);
                        inputNumbers.Insert(element1Position, int.Parse(command[2]));
                    }
                }
                else
                {
                    if (!(int.Parse(command[1]) - 1 > inputNumbers.Count))
                    {
                        inputNumbers.Insert(int.Parse(command[1]) + 1, int.Parse(command[2]));
                    }
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", inputNumbers));
        }
    }
}