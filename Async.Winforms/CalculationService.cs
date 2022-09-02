using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

// https://docs.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/

namespace Jarai.CSharp.Async.Winforms
{
    internal class CalculationService
    {
        public CalculationResult Calculate(IEnumerable<int> input)
        {
            var result = new CalculationResult(input.Sum());

            Thread.Sleep(3000); // Simulate long running operation

            return result;
        }

        public Task<CalculationResult> CalculateAsync(IEnumerable<int> input)
        {
            var task = Task.Run(() => Calculate(input));

            return task;
        }
    }
}