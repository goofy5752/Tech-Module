using System;

namespace Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	“Water” – for “Athlete”
            //•	“Coffee” – for “Businessman” or “Businesswoman”
            //•	“Beer” – for “SoftUni Student”
            //•	“Tea” – for all other professions.
            string input = Console.ReadLine();

            switch (input)
            {
                case "Athlete":
                    Console.WriteLine("Water");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }

        }
    }
}
