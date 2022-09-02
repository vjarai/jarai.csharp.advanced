using System;
using System.Threading.Tasks;

namespace Jarai.CSharp.Async.Example2
{
    internal class Program
    {
        private static async void LongProcess()
        {
            Console.WriteLine("LongProcess Started");

            await Task.Delay(4000); // hold execution for 4 seconds

            Console.WriteLine("LongProcess Completed");
        }

        private static async Task Main(string[] args)
        {
            LongProcess();

            ShortProcess();

            Console.ReadLine();
        }

        private static void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started");

            //do something here

            Console.WriteLine("ShortProcess Completed");
        }
    }
}