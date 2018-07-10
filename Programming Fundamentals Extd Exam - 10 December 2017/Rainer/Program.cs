using System;
using System.Collections.Generic;
using System.Linq;

namespace Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var finalList = new List<int>();
            bool isWet = true;
            int index = input.Last();
            int counter = 0;
            input.RemoveAt(input.Count - 1);
            for (int i = 0; i < input.Count; i++)
            {
                finalList.Add(input[i]);
            }
            if (finalList[index] != 0)
            {
                for (int i = 0; i < finalList.Count; i++)
                {
                    finalList[i]--;
                }
            }
            if (finalList[index] == 0)
            {
                Console.WriteLine(string.Join(" ", finalList));
                Console.WriteLine(counter);
            }
            else
            {
                while (isWet)
                {
                    index = int.Parse(Console.ReadLine());
                    if (finalList[index] != 0)
                    {
                        for (int i = 0; i < finalList.Count; i++)
                        {
                            finalList[i]--;
                            if (finalList[i] == 0 && index != i)
                            {
                                finalList[i] = input[i];
                            }
                            if (finalList[i] == 0 && index == i)
                            {
                                isWet = false;
                                for (int j = i + 1; j < finalList.Count; j++)
                                {
                                    finalList[j]--;
                                }
                                break;
                            }
                        }
                    }
                    if (finalList[index] == 0)
                    {
                        isWet = false;
                    }
                    counter++;
                }
                Console.WriteLine(string.Join(" ", finalList));
                Console.WriteLine(counter);

            }

        }
    }
}