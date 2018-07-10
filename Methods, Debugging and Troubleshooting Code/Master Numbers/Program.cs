using System;

namespace Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }

        }

        private static bool IsPalindrome(int number)
        {
            int left = number;
            int rev = 0;
            while (left > 0)
            {
                int r = left % 10;
                rev = rev * 10 + r;
                left /= 10;
            }

            if (rev == number)
            {
                return true;
            }

            return false;

        }

        private static bool SumOfDigits(int number)
        {
            int sum = 0;
            int tmp = number;
            while (tmp > 0)
            {
                sum += tmp % 10;
                tmp /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }

            return false;
        }

        private static bool ContainsEvenDigit(int number)
        {
            int tmp = number;
            while (tmp > 0)
            {
                if (tmp % 2 == 0)
                {
                    return true;
                }
                tmp /= 10;
            }

            return false;
        }
    }
}