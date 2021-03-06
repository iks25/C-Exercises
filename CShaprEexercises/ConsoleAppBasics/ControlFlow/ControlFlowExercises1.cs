using System;

namespace ConsoleAppBasics
{
    partial class Program
    {
        class ControlFlowExercises1
        {
            /// <summary>
            /// exerscise1 from exercises1
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


        }
    }
}
