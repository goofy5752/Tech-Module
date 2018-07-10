using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double totalPrice =
                (lightsabersPrice * (Math.Ceiling(studentsCount + (studentsCount * 0.10)))) + (robesPrice * studentsCount) + (beltsPrice * studentsCount);
            if (totalPrice <= amountMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice - amountMoney:F2}lv more.");
            }
        }
    }
}