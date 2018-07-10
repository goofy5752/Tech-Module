using System;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            if (input == "triangle" || input == "rectangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                TriRect(input, num1, num2);
            }
            else
            {
                double num1 = double.Parse(Console.ReadLine());
                CircSquare(input, num1);
            }
        }
        static void TriRect(string figure, double num1, double num2)
        {
            switch (figure)
            {
                case "triangle":
                    Console.WriteLine($"{((num1 * num2) / 2):F2}");
                    break;
                case "rectangle":
                    Console.WriteLine($"{(num1 * num2):F2}");
                    break;
            }
        }
        static void CircSquare(string figure, double num1)
        {
            if (figure == "circle")
            {
                Console.WriteLine($"{((Math.PI * num1 * num1)):F2}");
            }
            else if (figure == "square")
            {
                Console.WriteLine($"{(num1 * num1):F2}");
            }
        }
    }
}