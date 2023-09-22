namespace Jarai.CSharp.Async.Example4
{
    internal class Program
    {
        private static async Task<int> LongProcess1()
        {
            Console.WriteLine("LongProcess 1 Started");
            await Task.Delay(5000); 

            Console.WriteLine("LongProcess 1 Completed");

            return 10;
        }

        private static async Task<int> LongProcess2()
        {
            Console.WriteLine("LongProcess 2 Started");
            await Task.Delay(1000); 

            Console.WriteLine("LongProcess 2 Completed");

            return 20;
        }

        private static async Task Main(string[] args)
        {
            var process1 = LongProcess1();
            var process2 = LongProcess2();

            Console.WriteLine("After two long processes.");

            int process1Result = await process1; 
            Console.WriteLine($"Ergebnis von Prozess1: {process1Result}");

            int process2Result = await process2; 
            Console.WriteLine($"Ergebnis von Prozess2: {process2Result}");

            Console.ReadKey();
        }
    }
}