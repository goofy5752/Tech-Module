using System;

namespace Palindrome_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            int y1 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()),
                y2 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            PrintPalindromeDates(y1, y2);
        }

        static int MAX_VALID_YR = 9999;
        static int MIN_VALID_YR = 1000;

        // Returns true if 
        // given year is valid 
        static bool IsLeap(int year)
        {
            // Return true if year 
            // is a multiple pf 4 and 
            // not multiple of 100. 
            // OR year is multiple of 400. 
            return (((year % 4 == 0) &&
                     (year % 100 != 0)) ||
                     (year % 400 == 0));
        }

        // Returns true if given 
        // year is valid or not. 
        static bool IsValidDate(int d, int m, int y)
        {
            // If year, month and day 
            // are not in given range 
            if (y > MAX_VALID_YR || y < MIN_VALID_YR)
                return false;
            if (m < 1 || m > 12)
                return false;
            if (d < 1 || d > 31)
                return false;

            // Handle February month 
            // with leap year 
            if (m == 2)
            {
                if (IsLeap(y))
                    return (d <= 29);
                else
                    return (d <= 28);
            }

            // Months of April, June, 
            // Sept and Nov must have 
            // number of days less than 
            // or equal to 30. 
            if (m == 4 || m == 6 || m == 9 || m == 11)
                return (d <= 30);

            return true;
        }

        // Function to print the palindrome 
        // dates between the given years 
        static void PrintPalindromeDates(int y1, int y2)
        {

            // For every year 
            for (int year = y1; year <= y2; year++)
            {

                // Current year as a String 
                String str = String.Join("", year);

                // To store the reverse of year 
                String rev = str;
                rev = Reverse(rev);

                // Get the day and the month 
                int day = Int32.Parse(rev.Substring(0, 2));
                int month = Int32.Parse(rev.Substring(2, 2));

                // If the current palindrome date is valid 
                if (IsValidDate(day, month, year))
                {
                    var date = rev.Substring(0,2) + "/" + rev.Substring(2,2);
                    Console.Write(date.ToString() + "/" + str + "\n");
                }
            }
        }

        static String Reverse(String input)
        {
            char[] a = input.ToCharArray();
            int l, r = a.Length - 1;
            for (l = 0; l < r; l++, r--)
            {
                char temp = a[l];
                a[l] = a[r];
                a[r] = temp;
            }
            return String.Join("", a);
        }
    }
}