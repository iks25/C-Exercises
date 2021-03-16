using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.WorkingWithText
{
    class ValidTimeProgram : IConsoleAplication
    {
        public void ShowOnConsole()
        {
            Console.WriteLine(
                "please enter a time value in the 24-hour time format (e.g. 19:00)");
            var input = Console.ReadLine();

            bool isValidTime = TextHelper.IsValidTime(input);

            if (isValidTime)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Invalid Time");


        }
    }
}
