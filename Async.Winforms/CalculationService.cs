

// https://docs.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/

using System.ComponentModel;

namespace Jarai.CSharp.Async.Winforms
{
    internal class CalculationService
    {
        public event EventHandler<ProgressChangedEventArgs> ProgressChanged;

        public CalculationResult Calculate(IEnumerable<int> input, CancellationToken cancellationToken)
        {
            var result = 0;

            foreach (var i in input)
            {
                result += i;
                Thread.Sleep(3); // Simulate long running operation

                // Kooperatives Abbrechen

                cancellationToken.ThrowIfCancellationRequested(); // Abort, if canceled from UI
            }

            return new CalculationResult(result);
        }

        public async Task<CalculationResult> CalculateAsync(IEnumerable<int> input, CancellationToken cancellationToken)
        {
            var progress = 0;

            for (int i = 0; i < 100; i++)
            {
                ProgressChanged?.Invoke(this, new ProgressChangedEventArgs(progress++, null));
                await Task.Delay(50, cancellationToken); // Simulate long running operation
            }

            return new CalculationResult(input.Sum());
        }
    }
}