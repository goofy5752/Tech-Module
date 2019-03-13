using System;

namespace Spring_Vacation_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int vacationLenght = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int groupOfPeople = int.Parse(Console.ReadLine());
            double fuelPricePerKM = double.Parse(Console.ReadLine());
            double foodExpensesPerPPL = double.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());

            double totalFoodExpenses = foodExpensesPerPPL * groupOfPeople * vacationLenght;
            double totalHotelPrice = pricePerNight * groupOfPeople * vacationLenght;
            if (groupOfPeople > 10)
            {
                totalHotelPrice *= 0.75;
            }

            double totalDistanceExpenses = totalHotelPrice + totalFoodExpenses;

            for (int i = 1; i <= vacationLenght; i++)
            {
                if (budget < totalDistanceExpenses)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {totalDistanceExpenses - budget:F2}$ more.");
                    break;
                }
                double distanceTravelled = double.Parse(Console.ReadLine());
                totalDistanceExpenses += distanceTravelled * fuelPricePerKM;

                if (i % 3 == 0 || i % 5 == 0)
                {
                    totalDistanceExpenses += totalDistanceExpenses * 0.4;
                }

                if (i % 7 == 0)
                {
                    totalDistanceExpenses -= totalDistanceExpenses / groupOfPeople;
                }

                if (budget < totalDistanceExpenses)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {totalDistanceExpenses - budget:F2}$ more.");
                    break;
                }
            }

            if (totalDistanceExpenses <= budget)
            {
                Console.WriteLine($"You have reached the destination. You have {budget - totalDistanceExpenses:F2}$ budget left.");
            }
        }
    }
}