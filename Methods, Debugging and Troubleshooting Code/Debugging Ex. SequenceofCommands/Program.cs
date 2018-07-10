using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            string[] line = command.Split();
            int[] args = new int[2];

            if (line[0].Equals("add") ||
                line[0].Equals("subtract") ||
                line[0].Equals("multiply"))
            {
                args[0] = int.Parse(line[1]);
                args[1] = int.Parse(line[2]);

                PerformAction(array, line[0], args);
            }
            if (line[0].Equals("rshift"))
            {
                Console.WriteLine(string.Join(" ", shiftRight(array)));
            }
            else if (line[0].Equals("lshift"))
            {
                Console.WriteLine(string.Join(" ",shiftLeft(array)));
            }
            else
            {
                PrintArray(array);
            }

            Console.WriteLine();

            command = Console.ReadLine();
        }
    }

    static void PerformAction(long[] arr, string action, int[] args)
    {
        long[] array = arr.Clone() as long[];
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                arr[pos - 1] *= value;
                break;
            case "add":
                arr[pos - 1] += value;
                break;
            case "subtract":
                arr[pos - 1] -= value;
                break;
            case "lshift":
                shiftLeft(arr);
                break;
            case "rshift":
                shiftRight(arr);
                break;
        }
    }

    public static long[] shiftRight(long[] arr)
    {
        long[] demo = new long[arr.Length];

        for (int i = 1; i < arr.Length; i++)
        {
            demo[i] = arr[i - 1];
        }

        demo[0] = arr[demo.Length - 1];

        return demo;
    }

    public static long[] shiftLeft(long[] arr)
    {
        long[] demo = new long[arr.Length];

        for (int i = 0; i < arr.Length - 1; i++)
        {
            demo[i] = arr[i + 1];
        }

        demo[demo.Length - 1] = arr[0];

        return demo;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}