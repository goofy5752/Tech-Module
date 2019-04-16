using System;
using System.Collections.Generic;
using System.Linq;

namespace TestJobInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = {'a', 'b', 'b', 'a', 'c', 'v'};
            Console.WriteLine(UniqueChar(chars));
           
        }

        static string ReverseString(string input)
        {
            string reversedInput = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedInput += input[i];
            }

            return reversedInput;
        }

        static bool isHeavyNumber(int input)
        {
            var digits = input.ToString()
                .Select(x => int.Parse(x.ToString()));

            int totalSum = 0;

            foreach (var digit in digits)
            {
                totalSum += digit;
            }

            if (totalSum / digits.Count() > 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static char UniqueChar(char[] input)
        {
            var dict = new Dictionary<char, int>();

            foreach (var item in input)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 0);
                }

                dict[item]++;
            }

            char firstNonRepeatableChar = ' ';

            foreach (var item in dict.Where(x => x.Value == 1))
            {
                firstNonRepeatableChar = item.Key;
                break;
            }

            return firstNonRepeatableChar;
        }
    }
}
