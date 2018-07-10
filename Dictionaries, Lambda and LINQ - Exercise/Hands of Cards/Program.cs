using System;
using System.Collections.Generic;
using System.Linq;

namespace Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "JOKER")
                {
                    break;
                }
                int indexOfSubstring = input.IndexOf(":");
                string playerName = input.Substring(0, indexOfSubstring);
                var splittedInput = input
                    .Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Where(x => x.Length == 2 || x.Length == 3)
                    .Distinct()
                    .ToList();
                int totalSumToAdd = 0;
                for (int i = 0; i < splittedInput.Count; i++)
                {
                    int firstNum = 0;
                    var sumToAdd = splittedInput[i].ToCharArray();
                    if (char.IsDigit(sumToAdd[0]))
                    {
                        if (sumToAdd[0] == '1')
                        {
                            firstNum = 10;
                        }
                        else
                        {
                            firstNum = (int)Char.GetNumericValue(sumToAdd[0]);
                        }
                    }
                    else
                    {
                        if (sumToAdd[0] == 'J')
                        {
                            firstNum = 11;
                        }
                        else if (sumToAdd[0] == 'Q')
                        {
                            firstNum = 12;
                        }
                        else if (sumToAdd[0] == 'K')
                        {
                            firstNum = 13;
                        }
                        else if (sumToAdd[0] == 'A')
                        {
                            firstNum = 14;
                        }
                    }
                    if (sumToAdd[1] == 'C')
                    {
                        totalSumToAdd += firstNum;
                    }
                    else if (sumToAdd[1] == 'D')
                    {
                        totalSumToAdd += firstNum * 2;
                    }
                    else if (sumToAdd[1] == 'H')
                    {
                        totalSumToAdd += firstNum * 3;
                    }
                    else
                    {
                        totalSumToAdd += firstNum * 4;
                    }
                }
                if (!dict.ContainsKey(playerName))
                {
                    dict.Add(playerName, totalSumToAdd);
                }
                else
                {
                    dict[playerName] += totalSumToAdd;
                }
                totalSumToAdd = 0;
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}