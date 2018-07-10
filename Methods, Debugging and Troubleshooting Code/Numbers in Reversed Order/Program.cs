using System;

namespace Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            ReverseNumber(number);
        }
        static void ReverseNumber(double number)
        {
            Console.WriteLine(double.Parse(ReverseString(number.ToString())));
        }
        static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}