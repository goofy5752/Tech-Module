using System;

namespace Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintOnConsole(name);
        }
        static void PrintOnConsole(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}