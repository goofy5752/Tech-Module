using System;

namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            sbyte demo = 0;
            byte demo2 = 0;
            short demo1 = 0;
            ushort demo3 = 0;
            int demo4 = 0;
            uint demo5 = 0;
            long demo6 = 0;

            string finalOutput = $"{input} can fit in:";
            if (input.Length <= 20)
            {
                if (sbyte.TryParse(input, out demo))
                {
                    finalOutput += "\n* sbyte";
                }
                if (byte.TryParse(input, out demo2))
                {
                    finalOutput += "\n* byte";
                }
                if (short.TryParse(input, out demo1))
                {
                    finalOutput += "\n* short";
                }
                if (ushort.TryParse(input, out demo3))
                {
                    finalOutput += "\n* ushort";
                }
                if (int.TryParse(input, out demo4))
                {
                    finalOutput += "\n* int";
                }
                if (uint.TryParse(input, out demo5))
                {
                    finalOutput += "\n* uint";
                }
                if (long.TryParse(input, out demo6))
                {
                    finalOutput += "\n* long";
                }
                Console.WriteLine(finalOutput);
            }
            else
            {
                Console.Write($"{input}");
                Console.WriteLine(" can't fit in any type");
            }
        }
    }
}