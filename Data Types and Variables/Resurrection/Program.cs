using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int phoenixes = int.Parse(Console.ReadLine());
            decimal totalYears = 0;
            for (int i = 0; i < phoenixes; i++)
            {
                decimal bodyLenght = decimal.Parse(Console.ReadLine());
                decimal bodyWidth = decimal.Parse(Console.ReadLine());
                decimal lenghtOfWing = decimal.Parse(Console.ReadLine());
                totalYears = (bodyLenght * bodyLenght) * (bodyWidth + 2 * lenghtOfWing);
                Console.WriteLine(totalYears);
            }
        }
    }
}