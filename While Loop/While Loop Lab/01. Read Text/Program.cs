using System;

namespace _01._Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!="Stop")
            {
                Console.WriteLine(input);
                input = Console.ReadLine();
            }
            for (string inp = Console.ReadLine(); inp != "Stop"; inp = Console.ReadLine())
            {
                Console.WriteLine(inp);
            }
        }
    }
}
