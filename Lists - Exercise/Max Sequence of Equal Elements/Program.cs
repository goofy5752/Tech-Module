using System;
using System.Collections.Generic;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int bestStart = 0;
            int bestLenght = 0;
            int counter = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(list[i + 1]))
                {
                    counter++;
                }
            }
        }
    }
}