using System;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 0; i < 100; i++)
            {
                string input = Console.ReadLine();
                try
                {
                    int.Parse(input);
                    counter++;
                }
                catch (Exception)
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
