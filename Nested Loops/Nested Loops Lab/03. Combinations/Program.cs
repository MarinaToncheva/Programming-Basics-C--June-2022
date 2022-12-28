using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int numFirst = 0; numFirst <= n; numFirst++)
            {
                for (int numSecond = 0; numSecond <= n; numSecond++)
                {
                    for (int numThird = 0; numThird <= n; numThird++)
                    {
                        
                        if (numFirst+numSecond+numThird==n)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
