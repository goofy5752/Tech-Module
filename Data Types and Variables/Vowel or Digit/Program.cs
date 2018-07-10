using System;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int a = 0;
            if (input == "a" || input == "u" || input == "o" || input == "e" || input == "i")
            {
                Console.WriteLine("vowel");
            }
            else if (int.TryParse(input , out a) == true)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}