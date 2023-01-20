using System;

namespace _08._Secret_Door_s_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundreds = int.Parse(Console.ReadLine());
            int dozens = int.Parse(Console.ReadLine());
            int units = int.Parse(Console.ReadLine());

            for (int i = 2; i <= hundreds; i+=2)
            {
                for (int j = 2; j <= dozens; j++)
                {
                    if (IsPrime(j))
                    {
                        for (int k = 2; k <= units; k+=2)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
        public static bool IsPrime(int j)
        {
            if (j == 1) return true;
            if (j <= 1) return false;
            if (j == 2) return true;
            if (j % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(j));

            for (int b = 3; b <= boundary; b += 2)
            {
                if (j % b == 0)
                    return false;
            }
            return true;
        }
    }
}
