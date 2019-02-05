using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int percent = n / 2;
            int counter = 0;
            while (n >= m)
            {
                n -= m;
                if (n == percent)
                {
                    if (y > 0)
                    {
                        n /= y;
                    }
                }
                counter++;
            }
            Console.WriteLine(n);
            Console.WriteLine(counter);
        }
    }
}