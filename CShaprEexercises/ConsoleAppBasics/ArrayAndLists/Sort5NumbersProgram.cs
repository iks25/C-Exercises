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

            List<int> inputs = GetDiffrentNumbersFromUser(5);

            inputs.Sort();

            ShowResults(inputs);

        }

        private static void ShowResults(List<int> inputsInts)
        {
            Console.WriteLine("sorted numbers are :");
            foreach (var item in inputsInts)
            {
                Console.Write(item + " ");
            }
        }



        private List<int> GetDiffrentNumbersFromUser(int amountOfNumbers)
        {
            List<int> numbers = new List<int>();

            if (amountOfNumbers < 0)
                throw new ArgumentOutOfRangeException
                    ("amount Numbers ca not be smaller then 0");

            while (numbers.Count < amountOfNumbers)
            {

                Console.WriteLine("plese enter a number");
                var input = Console.ReadLine();
                int inputNumber;
                try
                {
                    inputNumber = Convert.ToInt32(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("this is not a number, try again");
                    continue;
                }

                if (numbers.Contains(inputNumber))
                {
                    Console.WriteLine
                        ("sorry, number has been previously entered, try again");
                    continue;
                }

                numbers.Add(inputNumber);

            };
            return numbers;

        }
    }
}
