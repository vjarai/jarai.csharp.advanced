namespace Jarai.CSharp.Async.Example3
{
    internal class Program
    {
        private static async Task<int> LongProcess()
        {
            Console.WriteLine("LongProcess Started");

            await Task.Delay(4000); 

            Console.WriteLine("LongProcess Completed");

            return 10;
        }

        private static async Task Main(string[] args)
        {
            var longProcessTask = LongProcess();

            ShortProcess();

            int ergebnis = await longProcessTask; 

            Console.WriteLine($"Result: {ergebnis}");

            Console.ReadKey();
        }

        private static void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started");

            //do something here

            Console.WriteLine("ShortProcess Completed");
        }
    }
}