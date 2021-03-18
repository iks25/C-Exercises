using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.ArrayAndLists
{
    /// <summary>
    /// esecise 5 ArrayAndList
    /// </summary>
    class The3SmallestNumbersProgram : IConsoleAplication
    {
        public void ShowOnConsole()
        {

            List<int> numbers;
            while (true)
            {
                Console.WriteLine
                    ("please enter  list of comma separated numbers (e.g 5, 1, 9, 2, 10)");
                var input = Console.ReadLine();

                try
                {
                    numbers = ArrayAndListHelper.ConvertToNumbers(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("sorry Invalid List, list do not match scheme, try again");
                    continue;
                }

                if (numbers.Count < 5)
                {
                    Console.WriteLine("sorry Invalid List, you entered not enought numbers,try again");
                    continue;
                }

                break;

            }

            var smallestNumbers = ArrayAndListHelper.Get3SmallestNumbers(numbers);

            DisplayResults(smallestNumbers);

        }

        private void DisplayResults(List<int> smallestNumbers)
        {
            var smallestNumberStrings = String.Join(",", smallestNumbers);

            Console.WriteLine
                ("the 3 smallest numbers from numbers you entered are {0}"
                , smallestNumberStrings);
        }
    }
}
