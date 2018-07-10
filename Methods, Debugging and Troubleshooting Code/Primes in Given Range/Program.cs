using System;

namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, ctr;
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (num = start; num <= end; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
        }
    }
}