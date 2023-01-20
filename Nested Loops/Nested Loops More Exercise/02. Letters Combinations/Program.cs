using System;

namespace _02._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char beginLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char notNeededLetter = char.Parse(Console.ReadLine());
            int count = 0;
            for (char i = beginLetter; i <=endLetter; i++)
            {
                if (i != notNeededLetter)
                {
                    for (char j = beginLetter; j <= endLetter; j++)
                    {
                        if (j!=notNeededLetter)
                        {
                            for (char k = beginLetter; k <= endLetter; k++)
                            {
                                if (k != notNeededLetter)
                                {
                                    count++;
                                    Console.Write($"{i}{j}{k} ");

                                }
                            }
                        } 
                    }
                }     
            }
            Console.WriteLine(count);
        }
    }
}


