

// https://docs.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/

namespace Jarai.CSharp.Async.Winforms;

internal class CalculationService
{
    public CalculationResult Calculate(IEnumerable<int> input, CancellationToken cancellationToken)
    {
        var result = 0;

        foreach (var i in input)
        {
            result += i;
            Thread.Sleep(3); // Simulate long running operation

            cancellationToken.ThrowIfCancellationRequested(); // Abort, if canceled from UI
        }

        return new CalculationResult(result);
    }

    public Task<CalculationResult> CalculateAsync(IEnumerable<int> input, CancellationToken cancellationToken)
    {
        var task = Task.Run(() => Calculate(input, cancellationToken), cancellationToken);
        return task;
    }
}