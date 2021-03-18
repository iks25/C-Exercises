using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.ArrayAndLists
{
    class Sort5NumbersProgram : IConsoleAplication
    {
        public void ShowOnConsole()
        {
            Console.WriteLine("please enter 5 numbers");

            List<string> inputs = GetInputsFromUser(5);

            List<int> inputsInts;
            try
            {
                inputsInts = ConvertListStringToListNumbers(inputs);
            }
            catch (Exception)
            {
                Console.WriteLine("you should enter only numbers");
                return;
            }

            inputsInts.Sort();

            ShowResults(inputsInts);

        }

        private static void ShowResults(List<int> inputsInts)
        {
            Console.WriteLine("sorted numbers are :");
            foreach (var item in inputsInts)
            {
                Console.Write(item + " ");
            }
        }

        private List<int> ConvertListStringToListNumbers(List<string> listOfNumbers)
        {
            if (listOfNumbers == null)
                return null;
            if (listOfNumbers.Count == 0)
                return new List<int>();

            var result = new List<int>();
            foreach (var item in listOfNumbers)
            {
                try
                {
                    var number = Convert.ToInt32(item);
                    result.Add(number);
                }
                catch (Exception)
                {
                    throw new ArgumentException("all position in listOfNumbers should be number");
                }
            }

            return result;
        }

        private List<string> GetInputsFromUser(int numbersOfInputs)
        {
            var inputs = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("please enter a number");
                inputs.Add(Console.ReadLine());
            }
            return inputs;
        }
    }
}
