using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPPL = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());

            if (numberOfPPL <= capacityOfElevator)
            {
                Console.WriteLine(1);
            }
            else
            {
                int courses = (int)Math.Ceiling((double)numberOfPPL / capacityOfElevator);
                Console.WriteLine(courses);
            }
        }
    }
}
