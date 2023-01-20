using System;

namespace _04._Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int i = beginNum; i <=endNum; i++)
            {
                for (int j = beginNum; j <= endNum; j++)
                {
                    for (int k = beginNum; k <= endNum; k++)
                    {
                        for (int l = beginNum; l <= endNum; l++)
                        {
                            if (i%2==0 && l%2!=0 || i%2!=0 && l%2==0)
                            {
                                if (i>l)
                                {
                                    if ((j+k)%2==0)
                                    {
                                        Console.Write($"{i}{j}{k}{l} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
