using System;

namespace _05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine(); 
            int counter = 0;
            for (int position = 0; position <= text.Length-1; position++)
            {
                char symbol = text[position];
                Console.WriteLine(symbol);
                counter++;      
            }
            Console.WriteLine(counter);
        }
    }
}
