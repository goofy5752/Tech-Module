using System;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();

            int minLenght = Math.Min(input.Length, secondInput.Length);
            int leftCounter = 0;
            int rightCounter = 0;
            for (int i = 0; i < minLenght; i++)
            {
                if (input[i].Equals(secondInput[i]))
                {
                    leftCounter++;
                }
                if (input[input.Length - 1 - i].Equals(secondInput[secondInput.Length- 1 - i]))
                {
                    rightCounter++;
                }
            }
            Console.WriteLine(Math.Max(leftCounter,rightCounter));
        }
    }
}