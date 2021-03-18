using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.ArrayAndLists
{
    /// <summary>
    /// exercise 4
    /// </summary>
    public class UniqueNumbersProgram : IConsoleAplication
    {
        public void ShowOnConsole()
        {
            List<string> inputs = GetInputsFromUser();
            List<int> uniqueNumbers =
               ArrayAndListHelper.ConvertUniqueNumbersList(inputs);

            DisplayResult(uniqueNumbers);
        }

        private void DisplayResult(List<int> uniqueNumbers)
        {
            if (uniqueNumbers.Count == 0)
            {
                Console.WriteLine("sory you did not pass any number");
                return;
            }

            var resutString = String.Join(",", uniqueNumbers);

            Console.WriteLine
                ("nique numbers that you have entered are\n{0}", resutString);
        }

        private List<string> GetInputsFromUser()
        {
            var result = new List<string>();

            while (true)
            {
                Console.WriteLine
                    ("please enter a number, or enter \"Quit\" to exit");
                var input = Console.ReadLine();

                if (input.Equals("Quit"))
                    break;

                result.Add(input);
            }

            return result;
        }
    }
}
