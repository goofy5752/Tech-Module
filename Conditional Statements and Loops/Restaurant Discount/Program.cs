using System;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double totalPrice = 0;

            if (groupSize <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                switch (package)
                {
                    case "Normal":
                        totalPrice += ((2500 + 500) * 0.95) / groupSize;
                        Console.WriteLine($"The price per person is {totalPrice:F2}$");
                        break;
                    case "Gold":
                        totalPrice += ((2500 + 750) * 0.90) / groupSize;
                        Console.WriteLine($"The price per person is {totalPrice:F2}$");
                        break;
                    case "Platinum":
                        totalPrice += ((2500 + 1000) * 0.85) / groupSize;
                        Console.WriteLine($"The price per person is {totalPrice:F2}$");
                        break;
                }
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                switch (package)
                {
                    case "Normal":
                        totalPrice += ((5000 + 500) * 0.95) / groupSize;
                        Console.WriteLine($"The price per person is {totalPrice:F2}$");
                        break;
                    case "Gold":
                        totalPrice += ((5000 + 750) * 0.90) / groupSize;
                        Console.WriteLine($"The price per person is {totalPrice:F2}$");
                        break;
                    case "Platinum":
                        totalPrice += ((5000 + 1000) * 0.85) / groupSize;
                        Console.WriteLine($"The price per person is {totalPrice:F2}$");
                        break;
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                switch (package)
                {
                    case "Normal":
                        totalPrice += ((7500 + 500) * 0.95) / groupSize;
                        Console.WriteLine($"The price per person is {totalPrice:F2}$");
                        break;
                    case "Gold":
                        totalPrice += ((7500 + 750) * 0.90) / groupSize;
                        Console.WriteLine($"The price per person is {totalPrice:F2}$");
                        break;
                    case "Platinum":
                        totalPrice += ((7500 + 1000) * 0.85) / groupSize;
                        Console.WriteLine($"The price per person is {totalPrice:F2}$");
                        break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
