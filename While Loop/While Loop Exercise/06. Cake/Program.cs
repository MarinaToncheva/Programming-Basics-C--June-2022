using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int cakeSize = w * h;
            string input = Console.ReadLine();
            int cakePieces;
            while (input!="STOP")
            {
                cakePieces = int.Parse(input);
                if (cakeSize>=cakePieces)
                {
                    cakeSize -= cakePieces;
                }
                else
                {
                    Console.WriteLine($"No more cake left! You need {cakePieces-cakeSize} pieces more.");
                    cakeSize = 0;
                    break;
                }
                input = Console.ReadLine();
            }
            if (cakeSize>0)
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
        }
    }
}
