using System;
using System.Collections.Generic;
using System.Linq;

namespace Softuni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                var command = Console.ReadLine().Split(':', ' ');
                if (command[0] == "course")
                {
                    break;
                }
                if (command.Length == 2)
                {
                    if (command[0] == "Add")
                    {
                        if (!list.Contains(command[1]))
                        {
                            list.Add(command[1]);
                        }
                    }
                    else if (command[0] == "Remove")
                    {
                        if (list.Contains(command[1]))
                        {
                            if (list.Contains(command[1] + "-Exercise"))
                            {
                                list.Remove(command[1] + "-Exercise");
                            }
                            list.Remove(command[1]);
                        }
                    }
                    else
                    {
                        if (list.Contains(command[1]) && !list.Contains(command[1] + "-Exercise"))
                        {
                            int indexOfExercise = list.IndexOf(command[1]);
                            list.Insert(indexOfExercise, command[1] + "-Exercise");
                        }
                        else
                        {
                            list.Add(command[1]);
                            list.Add(command[1] + "-Exercise");
                        }
                    }
                }
                else
                {
                    if (command[0] == "Insert")
                    {
                        if (!list.Contains(command[1]) && (list.Count >= int.Parse(command[2]) || list.Count - 1 < int.Parse(command[2])))
                        {
                            list.Insert(int.Parse(command[2]), command[1]);
                        }
                    }
                    else
                    {
                        if (list.Contains(command[1]) && list.Contains(command[2]))
                        {
                            var indexOfFirst = list.IndexOf(command[1]);
                            var indexOfFirstExercise = list.IndexOf(command[1] + "-Exercise");
                            var indexOfSecondExercise = list.IndexOf(command[2] + "-Exercise");
                            var indexOfSecond = list.IndexOf(command[2]);
                            if (!list.Contains(command[1] + "-Exercise") && !list.Contains(command[2] + "-Exercise"))
                            {
                                list.Insert(indexOfFirst, command[2]);
                                list.RemoveAt(indexOfFirst + 1);
                                list.Insert(indexOfSecond, command[1]);
                                list.RemoveAt(indexOfSecond + 1);
                            }
                            else if (list.Contains(command[1] + "-Exercise") && !list.Contains(command[2] + "-Exercise"))
                            {
                                list.Insert(indexOfFirst, command[2]);
                                list.RemoveAt(indexOfFirst + 1);
                                list.RemoveAt(indexOfFirstExercise);
                                list.Insert(indexOfSecond, command[1]);
                                list.Insert(indexOfSecond + 1, command[1] + "-Exercise");
                                list.RemoveAt(indexOfSecond + 2);
                            }
                            else
                            {
                                list.Insert(indexOfFirst, command[2]);
                                list.Insert(indexOfFirst + 1, command[2] + "-Exercise");
                                list.RemoveAt(indexOfFirst + 2);
                                list.RemoveAt(indexOfSecond + 1);
                                list.RemoveAt(indexOfSecondExercise);
                                list.Insert(indexOfSecondExercise, command[1]);
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}." + string.Join("", list[i]));
            }
        }
    }
}