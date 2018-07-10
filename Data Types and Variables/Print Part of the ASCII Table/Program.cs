using System;

namespace Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());

            for (int i = n; i <= n1; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}