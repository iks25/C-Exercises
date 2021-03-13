using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.ControlFlow
{
    class LoopsSolution
    {

        /// <summary>
        /// exercise1
        /// </summary>
        public static void showNumbersOfNumberDivisibleBy3()
        {

            Console.WriteLine("number of number divisible by 3 from between 1 and 100 is ");
            Console.WriteLine(NumbersOfNumberDivisibleBy3());


        }
        /// <summary>
        /// number of number divisible by 3 from between 1 and 100
        /// </summary>
        /// <returns></returns>
        private static int NumbersOfNumberDivisibleBy3()
        {
            int result = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    result++;
                    Console.WriteLine(i);
                }
            }
            return result;
        }

        /// <summary>
        /// exercise 2
        /// </summary>
        public static void NumberOrOkProgram()
        {

            int sumOfEnteredNumbers = 0;
            while (true)
            {


                Console.WriteLine("enter a number or \"ok\" to exit");
                var input = Console.ReadLine();
                try
                {
                    int inputNumber = Convert.ToInt32(input);
                    sumOfEnteredNumbers += inputNumber;
                }
                catch (Exception)
                {

                    if (input.Equals("ok"))
                        break;
                }



            }
            Console.WriteLine("sum Of enterd number is {0}", sumOfEnteredNumbers);
        }

        /// <summary>
        /// exercise 3
        /// </summary>
        public static void FactorialProgram()
        {

            Console.WriteLine("please enter a positive number");
            var input = Console.ReadLine();
            int inputNumber;
            try
            {
                inputNumber = Convert.ToInt32(input);
            }
            catch (Exception)
            {

                Console.WriteLine("sorry you did not enter a number");
                return;
            }
            if (inputNumber < 0)
            {
                Console.WriteLine("entered number is not positive number");
                return;
            }

            ShowFactorial(inputNumber);

        }
        private static void ShowFactorial(int number)
        {

            Console.WriteLine("factorial of {0} is {1}", number, GetFactorial(number));
        }

        private static int GetFactorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        /// <summary>
        /// exercise 4
        /// </summary>
        public static void GuessNumberProgram()
        {
            var random = new Random();
            Console.WriteLine("try to gouess number from 1 to 10");
            var randomNumber = random.Next(1, 10);

            for (int remainingChances = 4; remainingChances > 0; remainingChances--)
            {
                Console.WriteLine("please enter number");
                var input = Console.ReadLine();
                int inputNumber = -1;
                bool isInputNumber = true;
                try
                {
                    inputNumber = Convert.ToInt32(input);
                }
                catch (Exception)
                {
                    isInputNumber = false;

                }

                if (isInputNumber && inputNumber == randomNumber)
                {
                    Console.WriteLine("You won !!! the number is {0}", randomNumber);
                    return;
                }
                else
                {
                    if (remainingChances - 1 > 1)
                    {
                        Console.WriteLine("bad answer try again \nyou still have {0} reamining chances", remainingChances - 1);
                    }
                    else
                    {
                        Console.WriteLine("bad answer try again \nit is your last chance");
                    }

                }


            }

            Console.WriteLine("Sorry You Lost, that number was {0}", randomNumber);

        }


    }
}
