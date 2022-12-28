using System;
using System.Text;

namespace _03._Stream_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            StringBuilder word = new StringBuilder();
            StringBuilder message = new StringBuilder();
            StringBuilder secretSymbols = new StringBuilder();
            int counterC = 0;
            int counterN = 0;
            int counterO = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                char currentLetter = char.Parse(input);
                if (currentLetter < 65 || currentLetter > 90 && currentLetter < 97 || currentLetter > 122)
                {
                    continue;
                }
                else if (currentLetter == 'c' || currentLetter == 'n' || currentLetter == 'o')
                {
                    if (currentLetter == 'c' && counterC == 0)
                    {
                        secretSymbols.Append(currentLetter);
                        counterC++;
                    }
                    else if (currentLetter == 'c' && counterC != 0)
                    {
                        word.Append(currentLetter);
                    }
                    if (currentLetter == 'n' && counterN == 0)
                    {
                        secretSymbols.Append(currentLetter);
                        counterN++;
                    }
                    else if (currentLetter == 'n' && counterN != 0)
                    {
                        word.Append(currentLetter);
                    }
                    if (currentLetter == 'o' && counterO == 0)
                    {
                        secretSymbols.Append(currentLetter);
                        counterO++;
                    }
                    else if (currentLetter == 'o' && counterO != 0)
                    {
                        word.Append(currentLetter);
                    }
                }
                else
                {
                    word.Append(currentLetter);
                }
                if (secretSymbols.Length == 3)
                {
                    message.Append(word);
                    message.Append(' ');
                    secretSymbols.Clear();
                    counterC = 0;
                    counterN = 0;
                    counterO = 0;
                    word.Clear();
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(message);
        }
    }
}