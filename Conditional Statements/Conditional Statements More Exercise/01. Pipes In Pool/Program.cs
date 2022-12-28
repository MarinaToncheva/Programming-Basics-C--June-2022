using System;

namespace _01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double litreP1 = p1 * h;
            double litreP2 = p2 * h;
            double allLitresInPercent = ((litreP1 + litreP2) / v) * 100.0;
            double percentPipeOne = (litreP1 / (litreP1 + litreP2)) * 100;
            double percentPipeTwo = (litreP2 / (litreP1 + litreP2)) * 100;
            double overFlow = (litreP1 + litreP2) - v;
            if ((litreP1+litreP2)>v)
            {
                Console.WriteLine($"For {h} hours the pool overflows with {overFlow} liters");
            }
            else
            {
                Console.WriteLine($"The pool is {allLitresInPercent} % full.Pipe 1: {percentPipeOne:f2}%.Pipe 2: {percentPipeTwo:f2}%");
            }
        }
    }
}
