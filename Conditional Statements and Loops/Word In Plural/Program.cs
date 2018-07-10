using System;

namespace Word_In_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.EndsWith("o")
                || input.EndsWith("ch")
                || input.EndsWith("s")
                || input.EndsWith("sh")
                || input.EndsWith("x")
                || input.EndsWith("z"))
            {
                input = input + "es";
            }
            else if (input.EndsWith("y"))
            {
                input = input.Remove(input.Length - 1);
                input = input + "ies";
            }
            else
            {
                input = input + "s";
            }
            Console.WriteLine(input);
        }
    }
}