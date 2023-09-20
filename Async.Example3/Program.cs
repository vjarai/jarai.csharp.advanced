namespace Jarai.CSharp.Async.Example3
{
    internal class Program
    {
        private static async Task<int> LongProcess()
        {
            Console.WriteLine("LongProcess Started");

            await Task.Delay(4000); // hold execution for 4 seconds

            Console.WriteLine("LongProcess Completed");

            return 10;
        }

        private static async Task Main(string[] args)
        {
            var longProcessTask = LongProcess();

            ShortProcess();

            var val = await longProcessTask; // wait untile get the return value

            Console.WriteLine($"Result: {val}");

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