using System;
using System.Threading;

namespace Jarai.CSharp.Async.Example1
{
    internal class Program
    {
        private static void LongProcess() 
        {
            Console.WriteLine("LongProcess Started");

            // simulate some code that takes long execution time 
            Thread.Sleep(4000); // hold execution for 4 seconds

            Console.WriteLine("LongProcess Completed");
        }

        private static void Main(string[] args)
        {
            LongProcess();

            ShortProcess();
        }

        private static void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started");

            //do something here

            Console.WriteLine("ShortProcess Completed");
        }
    }
}