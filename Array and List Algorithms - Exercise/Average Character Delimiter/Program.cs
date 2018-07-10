using System;
using System.Linq;
using System.Text;

namespace Average_Character_Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string trimmedInput = input.Replace(" ", "");
            int totalValue = 0;
            foreach (var item in trimmedInput)
            {
                totalValue += item;
            }
            int finalChar = totalValue / trimmedInput.Length;
            string finalOutput = input.Replace(' ', (char)finalChar);
            Console.WriteLine(finalOutput);
        }
    }
}