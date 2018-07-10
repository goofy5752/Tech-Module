using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] first = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            char[] second = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(char.Parse)
            .ToArray();

            int firstTotal = 0;
            int secondTotal = 0;

            for (int i = 0; i < first.Length; i++)
            {
                firstTotal += first[i];
            }
            for (int i = 0; i < second.Length; i++)
            {
                secondTotal += second[i];
            }
            if (firstTotal > secondTotal)
            {
                Console.WriteLine(string.Join("", second));
                Console.WriteLine(string.Join("", first));
            }
            else if (secondTotal > firstTotal)
            {
                Console.WriteLine(string.Join("", first));
                Console.WriteLine(string.Join("", second));
            }
            else
            {
                Console.WriteLine(string.Join("", first));
                Console.WriteLine(string.Join("", second));
            }
        }
    }
}