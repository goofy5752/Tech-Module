using System;

namespace Instruction_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();
            while (input[0] != "end")
            {
                if (input[0] == "inc")
                {
                    long inc = int.Parse(input[1]);
                    inc++;
                    Console.WriteLine(inc);
                }
                else if (input[0] == "add")
                {
                    long num1 = int.Parse(input[1]);
                    long num2 = int.Parse(input[2]);
                    long result = num1 + num2 ;
                    Console.WriteLine(result);
                }
                else if (input[0] == "dec")
                {
                    long num = long.Parse(input[1]);
                    num--;
                    Console.WriteLine(num);
                }
                else if (input[0] == "mla")
                {
                    long num1 = long.Parse(input[1]);
                    long num2 = long.Parse(input[2]);
                    long result = num1 * num2;
                    Console.WriteLine(result);
                }
                input = Console.ReadLine().ToLower().Split();
                //switch (opCode[0])
                //{
                //    case "INC":
                //        {
                //            int operandOne = int.Parse(opCode[1]);
                //            for (int i = 0; i < operandOne; i++)
                //            {
                //                result++;
                //            }
                //            break;
                //        }
                //    case "DEC":
                //        {
                //            int operandOne = int.Parse(opCode[1]);
                //            result = operandOne--;
                //            break;
                //        }
                //    case "ADD":
                //        {
                //            int operandOne = int.Parse(opCode[1]);
                //            int operandTwo = int.Parse(opCode[2]);
                //            result = operandOne + operandTwo;
                //            break;
                //        }
                //    case "MLA":
                //        {
                //            int operandOne = int.Parse(opCode[1]);
                //            int operandTwo = int.Parse(opCode[2]);
                //            result = (long)(operandOne * operandTwo);
                //            break;
                //        }
                //}
                
            }
        }
    }
}