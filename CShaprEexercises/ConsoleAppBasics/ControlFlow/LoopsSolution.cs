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
    }
}
