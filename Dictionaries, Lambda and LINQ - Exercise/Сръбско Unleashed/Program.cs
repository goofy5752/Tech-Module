using System;
using System.Collections.Generic;
using System.Linq;

namespace Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                var indexOfMaimunqka = input.IndexOf('@');
                if (input.ElementAt(indexOfMaimunqka - 1) != ' ')
                {
                    continue;
                }
                var name = input.Substring(0, indexOfMaimunqka - 1);
                var secondPartToDo = input.Substring(indexOfMaimunqka + 1, input.Length - indexOfMaimunqka - 1);
                var splittedSecondPart = secondPartToDo.Split();
                var toCharArray = splittedSecondPart[0].ToCharArray();
                
                bool isTrue = false;
                for (int i = 0; i < toCharArray.Length; i++)
                {
                    if (char.IsDigit(toCharArray[i]))
                    {
                        isTrue = true;
                    }
                }
                if (isTrue)
                {
                    continue;
                }
                var partyPlace = "";
                long ticketPrice = 0;
                long ticketCount = 0;
                if (splittedSecondPart.Length == 3)
                {
                    var secondCharArray = splittedSecondPart[1].ToCharArray();
                    int a = 0;
                    if (int.TryParse(splittedSecondPart[1], out a) == false)
                    {
                        continue;
                    }
                    partyPlace = splittedSecondPart[0];
                    ticketPrice = long.Parse(splittedSecondPart[1]);
                    ticketCount = long.Parse(splittedSecondPart[2]);
                }
                else if (splittedSecondPart.Length == 4)
                {
                    partyPlace = splittedSecondPart[0] + " " + splittedSecondPart[1];
                    ticketPrice = long.Parse(splittedSecondPart[2]);
                    ticketCount = long.Parse(splittedSecondPart[3]);
                }
                else
                {
                    partyPlace = splittedSecondPart[0] + " " + splittedSecondPart[1] + " " + splittedSecondPart[2];
                    ticketPrice = long.Parse(splittedSecondPart[3]);
                    ticketCount = long.Parse(splittedSecondPart[4]);
                }
                if (!dict.ContainsKey(partyPlace))
                {
                    dict.Add(partyPlace, new Dictionary<string, long>());
                }
                if (!dict[partyPlace].ContainsKey(name))
                {
                    dict[partyPlace].Add(name, ticketPrice * ticketCount);
                }
                else
                {
                    dict[partyPlace][name] += ticketCount * ticketPrice;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var kvp in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}