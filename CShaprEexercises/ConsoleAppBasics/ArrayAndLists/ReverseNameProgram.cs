using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.ArrayAndLists
{
    /// <summary>
    /// exercise 2 aray and Lists
    /// </summary>
    public class ReverseNameProgram : IConsoleAplication
    {
        public void ShowOnConsole()
        {
            Console.WriteLine("please enter your name");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("your input can not be empty");
                return;
            }

            var reversedInput = ArrayAndListHelper.ReverseText(input);

            Console.WriteLine("reversed text is:\n{0}", reversedInput);
        }
    }
}
