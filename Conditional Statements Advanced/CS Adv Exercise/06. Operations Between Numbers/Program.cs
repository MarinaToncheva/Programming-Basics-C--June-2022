using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            if (operation == "+"|| operation =="-" || operation == "*" )
            {
                int result = 0;
                string evenOrOdd = "even";
                if (operation=="+")
                {
                    result = numOne + numTwo;
                }
                else if (operation=="-")
                {
                    result = numOne - numTwo;
                }
                else
                {
                    result = numOne * numTwo;
                }
                if (result%2!=0)
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{numOne} {operation} {numTwo} = {result} - {evenOrOdd}");
            }
            else
            {
                if (numTwo==0)
                {
                    Console.WriteLine($"Cannot divide {numOne} by zero");
                }
                else
                {
                    double result;
                    if (operation=="/")
                    {
                        result = (double)numOne / numTwo;
                        Console.WriteLine($"{numOne} / {numTwo} = {result:f2}");
                    }
                    else
                    {
                        result = numOne % numTwo;
                        Console.WriteLine($"{numOne} % {numTwo} = {result}");
                    }
                }
            }
        }
    }
}
