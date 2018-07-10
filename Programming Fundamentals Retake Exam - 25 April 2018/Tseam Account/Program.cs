using System;
using System.Linq;

namespace Tseam_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = Console.ReadLine()
                .Split()
                .ToList();
            string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "Fight!")
            {
                if (command[0] == "Buy")
                {
                    if (!games.Contains(command[1]))
                    {
                        games.Add(command[1]);
                    }
                }
                else if (command[0] == "Trash")
                {
                    if (games.Contains(command[1]))
                    {
                        games.Remove(command[1]);
                    }
                }
                else if (command[0] == "Repair")
                {
                    if (games.Contains(command[1]))
                    {
                        games.Remove(command[1]);
                        games.Add(command[1]);
                    }
                }
                else
                {
                    var spliitedCommand = command[1].Split('-');
                    if (games.Contains(spliitedCommand[0]))
                    {
                        int indexToInsert = games.IndexOf(spliitedCommand[0]) + 1;
                        games.Insert(indexToInsert, spliitedCommand[0] + ":" + spliitedCommand[1]);

                    }
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", games));
        }
    }
}