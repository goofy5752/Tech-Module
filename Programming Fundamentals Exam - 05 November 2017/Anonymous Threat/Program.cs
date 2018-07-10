using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            var finalList = Console.ReadLine().Split().ToList();
            string[] input = Console.ReadLine().Split();
            StringBuilder sb = new StringBuilder();
            while (input[0] != "3:1")
            {
                string action = input[0];
                int firstIndex = int.Parse(input[1]);
                int secondIndex = int.Parse(input[2]);
                if (action == "merge")
                {
                    if (firstIndex < 0)
                    {
                        firstIndex = 0;
                    }
                    else if (secondIndex >= finalList.Count)
                    {
                        secondIndex = finalList.Count - 1;
                    }
                    for (int i = firstIndex; i < secondIndex; i++)
                    {
                        sb.Append(finalList[i]);
                    }
                    for (int i = firstIndex; i < secondIndex; i++)
                    {
                        finalList.RemoveAt(i);
                    }
                    //finalList.Add();
                }
                else if (action == "divide")
                {

                }
                input = Console.ReadLine().Split();
            }
        }
    }
}