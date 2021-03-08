using System;

namespace ConsoleAppBasics
{
    partial class Program
    {
        class ConditionalsSolution
        {

            /// <summary>
            /// exerscise:1
            /// </summary>
            public static void AskAboutNumber()
            {

                Console.WriteLine("please enter number from 1-10");
                var input = Console.ReadLine();

                try
                {
                    int inputNumer = Convert.ToInt32(input);

                    if (inputNumer >= 1 && inputNumer <= 10)
                        ShowValidMessage();
                    else
                        ShowInvalidMessage();
                }
                catch (Exception)
                {

                    ShowInvalidMessage();
                }

            }
            private static void ShowInvalidMessage()
            {
                Console.WriteLine("Ivalid");
            }
            private static void ShowValidMessage()
            {
                Console.WriteLine("Valid");
            }

            /// <summary>
            /// exercise: 2
            /// </summary>
            public static void BiggerNumber()
            {


                try
                {
                    Console.WriteLine("enter first number");
                    var input = Console.ReadLine();
                    int number1 = Convert.ToInt32(input);

                    Console.WriteLine("enter second number");
                    var input2 = Console.ReadLine();
                    int number2 = Convert.ToInt32(input);


                    int biggerNumber = (number1 > number2) ? number1 : number2;
                    Console.WriteLine("biger number is {0}", biggerNumber);

                }
                catch (Exception)
                {

                    Console.WriteLine("you didn't enter number");
                }

            }

            /// <summary>
            /// exercise:3
            /// </summary>
            public static void LandscapeOrPortrait()
            {

                try
                {

                    Console.WriteLine("enter height");
                    int height = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter width");
                    int width = Convert.ToInt32(Console.ReadLine());

                    if (width > height)
                    {
                        Console.WriteLine("the image is landscape");
                    }
                    else
                    {
                        Console.WriteLine("the image is portrait");

                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("you should enter number");
                }
            }


        }
    }
}
