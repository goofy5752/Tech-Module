using System;

namespace Memory_View
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            while (input[0] != "Visual")
            {
                var finalWord = "";
                for (int i = 0; i < input.Length; i++)
                {
                    if (int.Parse(input[i]) >= 65 
                        && int.Parse(input[i]) <= 122)
                    {
                        finalWord += (char)int.Parse(input[i]);
                    }
                }
                Console.WriteLine(finalWord);
                finalWord = "";
                input = Console.ReadLine().Split();
            }
        }
    }
}