using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.WorkingWithText
{
    class DuplicateProgram : IConsoleAplication
    {
        public void ShowOnConsole()
        {
            Console.WriteLine("please enter few numbers separated by a hyphen");
            var input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
            {

                return;
            }

            List<int> inputNumbers;
            try
            {
                inputNumbers = TextHelper.ConvertStringToNumberList(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            if (TextHelper.IsContainDuplicates(inputNumbers))
            {
                Console.WriteLine("Duplicate");
            }
            else
            {
                Console.WriteLine("not contain duplicate");
            }

        }
    }
}
