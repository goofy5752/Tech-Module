using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%([A-Z][a-z]+)%[^(|$%.)]*<(\w+)>[^(|$%.)]*\|([0-9]+)\|[^(|$%.0-9)]*([0-9]+.?[0-9]*)\$";
            decimal totalSum = 0;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }
                var isMatch = Regex.Match(input, pattern);
                if (isMatch.Success)
                {
                    var name = isMatch.Groups[1].Value.ToString();
                    var productName = isMatch.Groups[2].Value.ToString();
                    var productQuantity = isMatch.Groups[3].Value;
                    var productPrice = isMatch.Groups[4].Value;
                    decimal totalPrice = decimal.Parse(productPrice) * decimal.Parse(productQuantity);
                    Console.WriteLine($"{name}: {productName} - {totalPrice:F2}");
                    totalSum += totalPrice;
                }
            }
            Console.WriteLine($"Total income: {totalSum:F2}");
        }
    }
}