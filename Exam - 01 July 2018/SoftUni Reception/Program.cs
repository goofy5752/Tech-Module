using System;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int totalStudents = int.Parse(Console.ReadLine());
            int totalEmployee = firstEmployee + secondEmployee + thirdEmployee;
            int counter = 0;
            while (totalStudents > 0)
            {
                totalStudents -= totalEmployee;
                counter++;
                if (counter % 4 == 0)
                {
                    counter++;
                }
                if (totalEmployee < 0)
                {
                    counter--;
                    break;
                }
            }
            Console.WriteLine($"Time needed: {counter}h.");
        }
    }
}