using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.ArrayAndLists
{
    public class ArrayAndListSolutionRunner : ISolutionRunner
    {
        public void runSolution(int excerciseNr)
        {
            IConsoleAplication program;
            switch (excerciseNr)
            {
                case 1:
                    program = new WhoLikeYourPostProgram();
                    break;
                case 2:
                    program = new ReverseNameProgram();
                    break;
                case 3:
                    program = new Sort5NumbersProgram();
                    break;
                case 4:
                    program = new UniqueNumbersProgram();
                    break;
                case 5:
                    program = new The3SmallestNumbersProgram();
                    break;

                default:
                    Console.WriteLine("that exercise is not implemented");
                    return;

            }
            program.ShowOnConsole();
        }
    }
}
