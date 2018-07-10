using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double totalMousePrice = 0;
            double totalHeadsetPrice = 0;
            double totalKeyboardPrice = 0;
            double totalDisplayPrice = 0;
            bool isBrokenMouse = false;
            bool isBrokenHeadset = false;
            int counter = 1;

            for (int i = 0; i < lostGames; i++)
            {
                if (i + 1 % 2 == 0)
                {
                    totalHeadsetPrice += headsetPrice;
                    isBrokenHeadset = true;
                }
                if (i + 1 % 3 == 0)
                {
                    totalMousePrice += mousePrice;
                    isBrokenMouse = true;
                }
                if (isBrokenMouse && isBrokenHeadset)
                {
                    totalKeyboardPrice += keyboardPrice;
                    isBrokenMouse = false;
                    isBrokenHeadset = false;
                    counter++;
                }
                if (counter % 2 == 0)
                {
                    totalDisplayPrice += displayPrice;
                }
            }
            double totalPrice = totalDisplayPrice + totalHeadsetPrice + totalKeyboardPrice + totalMousePrice;
            Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");
        }
    }
}