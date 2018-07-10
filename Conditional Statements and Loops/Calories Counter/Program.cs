using System;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // •	Cheese – 500 calories
            // •	Tomato sauce – 150 calories
            // •	Salami – 600 calories
            // •	Pepper – 50 calories
            int n = int.Parse(Console.ReadLine());
            int totalCalories = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "cheese":
                        totalCalories += 500;
                        break;
                    case "tomato sauce":
                        totalCalories += 150;
                        break;
                    case "salami":
                        totalCalories += 600;
                        break;
                    case "pepper":
                        totalCalories += 50;
                        break;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}