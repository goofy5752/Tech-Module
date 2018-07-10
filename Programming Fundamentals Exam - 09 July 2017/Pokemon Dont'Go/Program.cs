using System;
using System.Linq;

namespace Pokemon_Dont_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            long sum = 0;
            while (input.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    input.Insert(0, input[input.Count - 1]);
                    input.RemoveAt(1);
                    index = 0;
                }
                if (index > input.Count - 1)
                {
                    input.Add(input[0]);
                    index = input.Count - 1;
                }
                int elementAtIndex = input.ElementAt(index);
                sum += elementAtIndex;
                input.RemoveAt(index);
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] <= elementAtIndex)
                    {
                        input[i] += elementAtIndex;
                    }
                    else if (input[i] > index)
                    {
                        input[i] -= elementAtIndex;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}