using System;

namespace _5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (Math.Abs(num1 - num2) > 4)
            {
                for (int i = num1; i <= num2; i++)
                {
                    for (int j = i + 1; j <= num2; j++)
                    {
                        for (int k = j + 1; k <= num2; k++)
                        {
                            for (int l = k + 1; l <= num2; l++)
                            {
                                for (int m = l + 1; m <= num2; m++)
                                {
                                    Console.WriteLine(i + " " + j + " " + k + " " + l + " " + m);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}