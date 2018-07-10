using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double studio = 0.0;
            double doublee = 0.0;
            double suite = 0.0;

            if (month == "May" || month == "October")
            {
                if (nightsCount > 7)
                {
                    if (month == "October")
                    {
                        studio = (50 * 0.95) * nightsCount - 50;
                        doublee = 65 * nightsCount;
                        suite = 75 * nightsCount;
                    }
                    else
                    {
                        studio = (50 * 0.95) * nightsCount;
                        doublee = 65 * nightsCount;
                        suite = 75 * nightsCount;
                    }
                }
                else
                {
                    studio = 50 * nightsCount;
                    doublee = 65 * nightsCount;
                    suite = 75 * nightsCount;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nightsCount > 7)
                {
                    if (month == "September")
                    {
                        studio = 60 * nightsCount - 60;
                        doublee = 72 * nightsCount;
                        suite = 82 * nightsCount;
                    }
                    else
                    {
                        studio = 60 * nightsCount;
                        doublee = 72 * nightsCount;
                        suite = 82 * nightsCount;
                    }
                    if (nightsCount > 14)
                    {
                        studio = 60 * nightsCount - 60;
                        doublee = (72 * 0.90) * nightsCount;
                        suite = 82 * nightsCount;
                    }
                }           
                else
                {
                    studio = 60 * nightsCount;
                    doublee = 72 * nightsCount;
                    suite = 82 * nightsCount;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                if (nightsCount > 14)
                {
                    studio = 68 * nightsCount;
                    doublee = 77 * nightsCount;
                    suite = (89 * 0.85) * nightsCount;
                }
                else
                {
                    studio = 68 * nightsCount;
                    doublee = 77 * nightsCount;
                    suite = 89 * nightsCount;
                }
            }
            Console.WriteLine($"Studio: {studio:F2} lv.");
            Console.WriteLine($"Double: {doublee:f2} lv.");
            Console.WriteLine($"Suite: {suite:f2} lv.");
        }
    }
}