using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.WorkingWithText
{
    /// <summary>
    /// Exercise 5 Working with text
    /// </summary>
    class VowelsCounterProgram : IConsoleAplication
    {
        public void ShowOnConsole()
        {
            Console.WriteLine("please enter english word");
            var input = Console.ReadLine();

            var numberOfVowels = TextHelper.CountVowels(input);

            if (numberOfVowels == 0)
                Console.WriteLine("your text do not contain vowels");
            else if (numberOfVowels == 1)
                Console.WriteLine("your text contain 1 vowel");
            else
                Console.WriteLine("your text contain {0} vowels", numberOfVowels);

        }
    }
}
