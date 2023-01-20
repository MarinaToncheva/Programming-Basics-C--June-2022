using System;

namespace _10._Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOneLevaCoins = int.Parse(Console.ReadLine());
            int numberOfTwoLevaCoins = int.Parse(Console.ReadLine());
            int numberOfFiveLevaBanknotes = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <=numberOfOneLevaCoins; i++)
            {
                for (int j = 0; j <=numberOfTwoLevaCoins; j++)
                {
                    for (int k = 0; k <=numberOfFiveLevaBanknotes; k++)
                    {
                        if ((i*1)+(j*2)+(k*5)==sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
