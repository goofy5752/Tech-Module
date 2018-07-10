using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = new Dictionary<string, int>();
            var sumbissions = new Dictionary<string, int>();
            while (true)
            {
                var input = Console.ReadLine().Split('-', ' ');
                if (input[0] == "exam")
                {
                    break;
                }
                if (input.Length == 2)
                {
                    participants.Remove(input[0]);
                    continue;
                }
                if (!participants.ContainsKey(input[0]))
                {
                    participants.Add(input[0], int.Parse(input[2]));
                }
                if (!sumbissions.ContainsKey(input[1]))
                {
                    sumbissions.Add(input[1], 1);
                }
                else
                {
                    sumbissions[input[1]]++;
                }
                if (participants.ContainsKey(input[0]))
                {
                    if (participants[input[0]] < int.Parse(input[2]))
                    {
                        participants[input[0]] = int.Parse(input[2]);
                    }
                }
            }
            Console.WriteLine("Results:");
            foreach (var item in participants.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in sumbissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}