using System;

namespace Debugging_Exercise._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char search = 'p';
            bool hasMatch = false;
            string found = string.Empty;
            while (true)
            {
                if (text.IndexOf(search) != -1)
                {
                    if (text.Length < text.IndexOf(search) + jump + 1)
                    {
                        jump = text.Length - text.IndexOf(search) - 1;
                    }
                    found = text.Substring(text.IndexOf(search), jump + 1);

                    Console.WriteLine(found);
                    text = text.Substring(text.IndexOf(search) + jump + 1);
                    hasMatch = true;
                }
                else
                {
                    break;
                }
            }

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i].Equals(Search))
            //    {
            //        hasMatch = true;

            //        int endIndex = jump + 1;

            //        if (endIndex > text.Length)
            //        {
            //            endIndex = text.Length;
            //        }
            //        string matchedString = text.Substring(i, jump);
            //        Console.WriteLine(matchedString);
            //        i += jump;
            //    }
            //}
            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}