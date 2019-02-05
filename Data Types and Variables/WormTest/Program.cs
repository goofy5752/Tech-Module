using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            double wormLenght = int.Parse(Console.ReadLine());
            double wormWidth = int.Parse(Console.ReadLine());
            double wormLenghtInCM = wormLenght * 100;
            double elSe = wormLenghtInCM / (wormWidth / 100);
            double iF = wormLenghtInCM * wormWidth;
            if (wormLenghtInCM % wormWidth == 0 || wormWidth == 0)
            {
                Console.WriteLine($"{iF:F2}");
            }
            else
            {
                Console.WriteLine($"{elSe:F2}%");
            }
        }
    }
}