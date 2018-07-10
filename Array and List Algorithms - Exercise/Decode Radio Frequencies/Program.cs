using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Decode_Radio_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var allNumber = new List<string>();
            var leftPart = new StringBuilder();
            var rightPart = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                allNumber.Add(input[i]);
            }
            for (int i = 0; i < allNumber.Count; i++)
            {
                var splittedNum = allNumber[i].Split('.');
                char chA = (char)int.Parse(splittedNum[0]);
                char chB = (char)int.Parse(splittedNum[1]);
                if (chA != 0)
                {
                    leftPart.Append(chA.ToString());
                }
                if (chB != 0)
                {
                    rightPart.Append(chB.ToString());
                }
            }
            string finalOutput = "" + leftPart.ToString() + string.Join("", rightPart.ToString().Reverse());
            Console.WriteLine(finalOutput);
        }
    }
}