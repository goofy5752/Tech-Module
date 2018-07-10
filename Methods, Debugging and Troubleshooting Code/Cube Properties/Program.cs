using System;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string toDo = Console.ReadLine();
            CubeProperties(n, toDo);
        }
        static void CubeProperties(double n, string toDo)
        {
            switch (toDo)
            {
                case "face":
                    Console.WriteLine($"{Math.Sqrt(2 * Math.Pow(n, 2)):F2}");
                    break;
                case "volume":
                    Console.WriteLine($"{Math.Pow(n, 3):F2}");
                    break;
                case "space":
                    Console.WriteLine($"{Math.Sqrt(3 * Math.Pow(n, 2)):F2}");
                    break;
                case "area":
                    Console.WriteLine($"{6 * Math.Pow(n, 2):F2}");
                    break;
            }
        }
    }
}