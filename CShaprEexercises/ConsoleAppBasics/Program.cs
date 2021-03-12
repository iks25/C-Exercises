using ConsoleAppBasics.classes;
using ConsoleAppBasics.ControlFlow;
using System;

namespace ConsoleAppBasics
{
    partial class Program
    {
        static void Main(string[] args)
        {

            var stopWatch = new StopWatch();

            stopWatch.Start();
            System.Threading.Thread.Sleep(1000);
            stopWatch.Stop();
            stopWatch.Start();
            stopWatch.Stop();

            System.Console.WriteLine(stopWatch.getDuration());
        }


    }
}
