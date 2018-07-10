using System;
using System.Collections.Generic;
using System.Linq;

namespace Mirror_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var finalList = new List<string>();
            string index = Console.ReadLine();
            while (index != "Print")
            {

                index = Console.ReadLine();
            }
        }
    }
}