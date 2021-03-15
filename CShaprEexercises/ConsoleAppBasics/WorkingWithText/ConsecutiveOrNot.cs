using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppBasics.WorkingWithText
{
    /// <summary>
    /// text exercise 1
    /// </summary>
    public class ConsecutiveOrNot : IConsolAplication
    {

        public void ShowOnConsole()
        {


            Console.WriteLine("please enter a few numbers separated by a hyphen" +
                "\nfor example: 1-2-3-4");
            var input = Console.ReadLine();
            List<int> numbers;

            try
            {

                numbers = TextHelper.ConvertStringToNumberList(input);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }

            var isConsecutive = IsNumbersConsecutive(numbers);

            if (isConsecutive)
            {
                Console.WriteLine("numbers are Consecutive");

            }
            else
            {
                Console.WriteLine("numbers are not Consecutive");
            }


        }


        /// <summary>
        /// retun false if list is null empty,
        /// return true for one element, and decreasing elemenst
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public bool IsNumbersConsecutive(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return false;
            }

            if (numbers.Count == 1)
            {
                return true;
            }

            bool isIncreasing = (numbers[0] + 1 == numbers[1]);

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (isIncreasing)
                {
                    if (numbers[i] + 1 == numbers[i + 1])
                        continue;
                    else
                        return false;
                }
                else
                {
                    if (numbers[i] - 1 == numbers[i + 1])
                        continue;
                    else
                        return false;
                }
            }
            return true;

        }


    }
}
