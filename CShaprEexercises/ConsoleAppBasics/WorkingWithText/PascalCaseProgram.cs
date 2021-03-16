using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.WorkingWithText
{

    public class PascalCaseProgram : IConsoleAplication
    {
        public void ShowOnConsole()
        {
            Console.WriteLine("please enter a few words separated by a space");
            var input = Console.ReadLine();

            var convertedInput = TextHelper.ConvertToPascalCase(input);

            Console.WriteLine("your input in PascalCase:\n{0}", convertedInput);

        }
    }

}
